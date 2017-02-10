using UnityEngine;
using System.Collections;

public class SnowballMove : MonoBehaviour {

	public Transform beginPos;
	public Transform endPos;

	private float speed = 10f;

	public bool isRolling = false;

	private bool rollOnce = true;


	// Use this for initialization
	void Start () {
	
		transform.localPosition = beginPos.localPosition;
		StartCoroutine (waitForRoll ());

	}
	
	// Update is called once per frame
	void Update () {


		if (isRolling) {
		
			transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * Time.deltaTime);

			if (rollOnce) {
				StartCoroutine (waitForRoll ());
				rollOnce = false;
			}
				
		} else {
		

				transform.position = beginPos.position;

		
		}
	
	}

	IEnumerator waitForRoll(){
	
		yield return new WaitForSeconds (5f);
		isRolling = false;
		yield return new WaitForSeconds (Random.Range(10f, 30f));
		rollOnce = true;
		isRolling = true;

	
	
	}
}
