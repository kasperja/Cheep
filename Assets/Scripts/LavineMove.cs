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


		if (isRolling) {

			if (pc2D.m_MaxSpeed < 9f) {

				transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

			} else {
				
				transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * Time.deltaTime);

			}

			if (rollOnce) {
				StartCoroutine (waitForRoll ());
				rollOnce = false;
			}

		} else {
			
			if (pc2D.m_MaxSpeed < 9f) {

				transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

			} else {
				transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);
			}

		}

		if (pc2D.isDead) {
		
			if(speed>0f)speed -= 1.8f * Time.deltaTime;
		
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
