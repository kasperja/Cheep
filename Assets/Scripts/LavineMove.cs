using UnityEngine;
using System.Collections;


public class LavineMove : MonoBehaviour {

	public Transform beginPos;
	public Transform endPos;
	public Transform endPosDeath;

	private float speed = 5f;

	public bool isRolling = false;

	private bool rollOnce = true;

	public PlatformerCharacter2D pc2D;

	public int touchCounter = 0;

	public GameObject normSpawn;
	public GameObject bossSpawn;
	public GameObject powerUpSpawn;
	public GameObject powerUpSuperSpawn;
	public GameObject powerUpTopSpawn;

	public bool deactivateOnce = true;

	public bool spamActive = false;




	// Use this for initialization
	void Start () {

		transform.localPosition = beginPos.localPosition;
		StartCoroutine (waitForRollStart ());

	}

	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyDown (KeyCode.Space) || Input.GetTouch (0).phase == TouchPhase.Began) {
		
			touchCounter += 1;

		
		}*/

		if(transform.position.x <= beginPos.position.x) {
			
			transform.position = beginPos.position;
		
		}

		speed = pc2D.m_MaxSpeed;


		if (isRolling) {



			if (touchCounter >= 15) {
			
				isRolling = false;
			
			}

			if(transform.position.x < endPos.position.x){
			if (speed < 9f) {

				transform.position += new Vector3(5f,0,0) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed / 200f * 2f * Time.deltaTime);

			} else {

				transform.position += new Vector3(5f,0,0) * Time.deltaTime;
			//	transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * 200f * Time.deltaTime);

			}

			if (rollOnce) {
				StartCoroutine (waitForRoll ());
					bossSpawn.SetActive (true);
					normSpawn.SetActive (false);
				
					deactivateOnce = true;
					pc2D.DestroyAllObjects ();
					powerUpSpawn.SetActive (false);
					powerUpSuperSpawn.SetActive (false);
					powerUpTopSpawn.SetActive (false);
					rollOnce = false;

			}
		}

		} else {



			if (deactivateOnce) {
				
				powerUpSpawn.SetActive (true);
				powerUpSuperSpawn.SetActive (true);
				powerUpTopSpawn.SetActive (true);
				bossSpawn.SetActive (false);
				normSpawn.SetActive (true);
				spamActive = false;
				deactivateOnce = false;
			}

			touchCounter = 0;
			
			if (speed < 9f) {
				
				transform.position += new Vector3(5f,0,0) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

			} else {

				transform.position -= new Vector3(5f,0,0) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);

			}

		}

		if (pc2D.isDead) {
		
			//if(pc2D.m_MaxSpeed > 0f) speed -= 10000.8f * Time.deltaTime;
		
		}

	}

	IEnumerator waitForRoll(){
		isRolling = true;

		yield return new WaitForSeconds (2f);

		spamActive = true;

		yield return new WaitForSeconds (Random.Range(15f,20f));
		rollOnce = true;
		isRolling = true;



	}
	IEnumerator waitForRollStart(){
		yield return new WaitForSeconds (Random.Range(15f,20f));

		isRolling = true;

		yield return new WaitForSeconds (2f);

		spamActive = true;

		yield return new WaitForSeconds (Random.Range(15f,20f));
		rollOnce = true;
		isRolling = true;



	}

}
