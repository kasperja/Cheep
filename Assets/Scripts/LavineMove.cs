using UnityEngine;
using System.Collections;

public class LavineMove : MonoBehaviour {

	public Transform beginPos;
	public Transform endPos;
	public Transform endPosDeath;

	private float speed = 5f;

	public bool isRolling = true;

	private bool rollOnce = true;

	public PlatformerCharacter2D pc2D;
	// Use this for initialization
	void Start () {

		transform.localPosition = beginPos.localPosition;
		StartCoroutine (waitForRoll ());

	}

	// Update is called once per frame
	void Update () {
		
		speed = pc2D.m_MaxSpeed;

		if (isRolling) {



			if (speed < 9f) {

				transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed / 200f * 2f * Time.deltaTime);

			} else {
				
				transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * 200f * Time.deltaTime);

			}

			if (rollOnce) {
				StartCoroutine (waitForRoll ());
				rollOnce = false;
			}

		} else {
			
			if (speed < 9f) {

				transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

			} else {
				transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);
			}

		}

		if (pc2D.isDead) {
		
			if(pc2D.m_MaxSpeed > 0f) speed -= 10000.8f * Time.deltaTime;
		
		}

	}

	IEnumerator waitForRoll(){

		yield return new WaitForSeconds (Random.Range(5f,10f));
		isRolling = false;
		yield return new WaitForSeconds (Random.Range(10f,30f));
		rollOnce = true;
		isRolling = true;



	}

}
