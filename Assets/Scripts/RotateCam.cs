using UnityEngine;
using System.Collections;

public class RotateCam : MonoBehaviour {

	private float angleMultiplier = 3f;
	public PlatformerCharacter2D pc2D;

	public float angle;

	private float maxAngle = 100f;
	private float minAngle = 5f;
	private float origMaxAngle = 100f;
	private float origMinAngle = 5f;
	private float t = 0f;

	private bool changeDirection = true;
	private bool down = true;

	// Use this for initialization
	void Start () {

		maxAngle = Random.Range (50f, 30f);
		minAngle = Random.Range (0f, 5f);
		origMaxAngle = maxAngle;
		origMinAngle = minAngle;
	
	}
	
	// Update is called once per frame
	void Update () {


		angle = gameObject.transform.rotation.eulerAngles.z;

		if (gameObject.transform.rotation.eulerAngles.z < 40f) {
			
			pc2D.decreaseSpeed = true;

		} else {
		
			pc2D.decreaseSpeed = false;
		
		}
		angleMultiplier += 0.0f * Time.deltaTime;

		if (angleMultiplier < 0f && changeDirection) {
		
			down = true;

		} else if(changeDirection){

			down = false;
		}

		if(t < 1f)t += 0.5f * Time.deltaTime;

		if (((gameObject.transform.rotation.eulerAngles.z >= maxAngle || gameObject.transform.rotation.eulerAngles.z <= minAngle)) && changeDirection) {


			angleMultiplier = -angleMultiplier;

				
				StartCoroutine (angleOfHill ());

				changeDirection = false;
			


		} 

		if(!pc2D.isDead) gameObject.transform.Rotate (Vector3.forward * Time.deltaTime * angleMultiplier);

		//if(!pc2D.isDead) gameObject.transform.Rotate (Vector3.forward * Time.deltaTime * angleMultiplier);

		if (transform.rotation.eulerAngles.z < 90f) {
			
		} else {
			//angleMultiplier = 0f;
			//gameObject.transform.Rotate (Vector3.forward * 0f);
		}
	
	}

	IEnumerator angleOfHill(){
		
		origMaxAngle = maxAngle;
		origMinAngle = minAngle;
		maxAngle = Random.Range (80f, 50f);
		minAngle = Random.Range (0f, 5f);
		yield return new WaitForSeconds (2f);
		changeDirection = true;

	
	}
}
