using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoxFollow : MonoBehaviour {

	public PlatformerCharacter2D target;
	public Vector2 focusAreaSize;
	public BoxCollider2D colliderBox;

	public float verticalOffset;
	public float horizontalOffset = 1f;

	public bool belowGround = false;

	FocusArea focusArea;

	public bool isSteep = false;
	public bool hasBeenBelow = false;
	private bool hasBeenBelowOnce = true;

	private bool groundOnce = false;

	public LavineMove lavineScript;

	private float zoomInPos = 4f;
	private float zoomOutPos = 0f;

	public Transform zoomPos;
	public Transform normPos;
	private Rigidbody2D rbPlayer;

	void Awake(){
	
		colliderBox = target.GetComponent<BoxCollider2D> ();
	
	}

	void Start(){

		focusArea = new FocusArea (colliderBox.bounds, focusAreaSize);
		rbPlayer = target.gameObject.GetComponent<Rigidbody2D> ();
	
	}

	void LateUpdate(){

		if (target.m_Grounded && groundOnce) {
			focusArea = new FocusArea (colliderBox.bounds, focusAreaSize);
			groundOnce = false;
		}

		focusArea.Update (colliderBox.bounds, focusAreaSize.y);


	
		Vector2 focusPosition = focusArea.centre + Vector2.up * verticalOffset;

		if (!belowGround) {
			
			if (lavineScript.spamActive) {
				transform.position = (Vector3)new Vector3 (Mathf.MoveTowards(transform.position.x, target.transform.position.x + horizontalOffset-0.5f, 5f * Time.deltaTime), Mathf.MoveTowards (transform.position.y, focusPosition.y+1f, 10f * Time.deltaTime), Mathf.MoveTowards (transform.position.z, zoomPos.position.z, 5f * Time.deltaTime)) /*+ Vector3.forward * -10*/;

			} else {
				if(rbPlayer.velocity.y + 1f < 0f){
					transform.position = (Vector3)new Vector3 (Mathf.MoveTowards (transform.position.x, target.transform.position.x + horizontalOffset, 5f * Time.deltaTime), Mathf.MoveTowards (transform.position.y, focusPosition.y, 10f * Time.deltaTime), Mathf.MoveTowards (transform.position.z, normPos.position.z, 0.5f * Time.deltaTime));
				} else{
					transform.position = (Vector3)new Vector3 (Mathf.MoveTowards (transform.position.x, target.transform.position.x + horizontalOffset, 5f * Time.deltaTime), Mathf.MoveTowards (transform.position.y, focusPosition.y, 10f * Time.deltaTime), Mathf.MoveTowards (transform.position.z, normPos.position.z, 5f * Time.deltaTime));
						

				} /*+ Vector3.forward * -10*/;
			}
		} else {
			groundOnce = true;
			transform.position = (Vector3)new Vector3(target.transform.position.x + horizontalOffset, transform.position.y, 0f) + Vector3.forward * -10;
		
		}


	}

	void OnDrawGizmos(){
	
		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawCube (focusArea.centre, focusAreaSize);

	}


	struct FocusArea{

		public Vector2 centre;
		public Vector2 velocity;
		float left, right;
		float top, bottom;

		public FocusArea(Bounds targetBounds, Vector2 size){

			left = targetBounds.center.x - size.x/2;
			right = targetBounds.center.x + size.x/2;
			bottom = targetBounds.min.y;
			top = targetBounds.min.y + size.y;

			velocity = Vector2.zero;
			centre = new Vector2((left+right)/2, (top + bottom)/2);
		}

		public void Update(Bounds targetBounds, float focusAreaS){
		
			float shiftX = 0;
			if (targetBounds.min.x < left) {
			
				shiftX = targetBounds.min.x - left;


			} else if (targetBounds.max.x > right) {
			
				shiftX = targetBounds.max.x - right;
			
			}

			left = targetBounds.center.x - 100f;
			right = targetBounds.center.x + 100f;

			float shiftY = 0;
			if (targetBounds.min.y < bottom) {

				shiftY = targetBounds.min.y - bottom;


			} else if (targetBounds.max.y > top) {

				//top = focusAreaS/2f;

				shiftY = targetBounds.max.y - top;

			}

			top += shiftY * 20f * Time.deltaTime;
			bottom += shiftY * 20f * Time.deltaTime;

			centre = new Vector2 ((left + right) / 2, (top + bottom) / 2);
			velocity = new Vector2 (shiftX, shiftY);
		}

	}





}
