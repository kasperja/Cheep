﻿using UnityEngine;
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

	public bool isReady = false;
	private bool readyOnce = true;

	public DestroyerScript destroyBot;

	private bool isDeadByLavine = false;

	public bool lavineTest = false;

	public AudioSource lavineSoundLoop;
	public float randomSoundFloat = 0f;

	public ParticleSystem lavineDeathParticle;

	public float tTap = 0f;
	public GameObject tapTapObj;
	public GameObject feedbackTextObj;

	private Color colFeedbackText;

	public bool tapTapReady = false;
	// Use this for initialization
	void Start () {

		colFeedbackText = feedbackTextObj.GetComponent<TextMesh> ().color;
		feedbackTextObj.GetComponent<TextMesh> ().color = new Color (1f,1f,1f, 1f);


		transform.localPosition = beginPos.localPosition;
		StartCoroutine (setRollingTrue ());

	}

	// Update is called once per frame
	void Update () {
		randomSoundFloat = Random.Range (0f,1f);
		/*if (Input.GetKeyDown (KeyCode.Space) || Input.GetTouch (0).phase == TouchPhase.Began) {
		
			touchCounter += 1;
	
		
		}*/

		if (isDeadByLavine) {
			
			transform.position += new Vector3 (10f, 0, 0) * Time.deltaTime;
		
		}

		if(transform.position.x <= beginPos.position.x) {
			
			transform.position = beginPos.position;
		
		}

		speed = pc2D.m_MaxSpeed;


		if (isRolling) {



			if (tapTapReady) {
				
				if (tTap < 10f)
					tTap += 1f * Time.deltaTime;

				if (tTap < 0.5f) {

					tapTapObj.SetActive (false);
				
				} else {
				
					tapTapObj.SetActive (true);

				
				}
			} else {
			
				tapTapObj.SetActive (false);
			
			}

			if(lavineSoundLoop.volume < 0.7f)lavineSoundLoop.volume += 0.5f * Time.deltaTime;

			if (pc2D.isDead) {


				//transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;

			}


			if (touchCounter >= 15) {
				
				deactivateOnce = true;
				isRolling = false;

			
			}



			if (transform.position.x < endPos.position.x) {
				if (speed < 9f && !pc2D.isDead) {

					transform.position += new Vector3 (5f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed / 200f * 2f * Time.deltaTime);

				} else if (!pc2D.isDead) {

					transform.position += new Vector3 (5f, 0, 0) * Time.deltaTime;
					//	transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * 200f * Time.deltaTime);

				}

				if (rollOnce && !pc2D.isDead) {

					StartCoroutine (waitDeath ());
					StartCoroutine (vibrateNum ());

					//StartCoroutine (waitForRoll ());

				
					deactivateOnce = true;
					//pc2D.DestroyAllObjects ();
					powerUpSpawn.SetActive (false);
					powerUpSuperSpawn.SetActive (false);
					powerUpTopSpawn.SetActive (false);
					rollOnce = false;

				}
			}

			feedbackTextObj.GetComponent<TextMesh> ().color = colFeedbackText;
			
		} else {



			tapTapObj.SetActive (false);

			if(lavineSoundLoop.volume > 0f)lavineSoundLoop.volume -= 0.5f * Time.deltaTime;

			if (deactivateOnce && !pc2D.isDead && !isDeadByLavine) {
				
				//Debug.Log ("deactivated");
				Handheld.Vibrate();
				powerUpSpawn.SetActive (true);
				powerUpSuperSpawn.SetActive (true);
				powerUpTopSpawn.SetActive (true);
				bossSpawn.SetActive (false);
				normSpawn.SetActive (true);
				spamActive = false;
				//isReady = false;
				StartCoroutine (setRollingTrue ());
				deactivateOnce = false;



			}

			touchCounter = 0;
			if (transform.position.x > beginPos.position.x && !isDeadByLavine) {
				if (speed < 9f) {
				
					transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

				} else if(!isDeadByLavine){

					transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);

				}

			}
		}
		

		if (pc2D.isDead) {
		
			//if(pc2D.m_MaxSpeed > 0f) speed -= 10000.8f * Time.deltaTime;
		
		}


	}

	IEnumerator waitForRoll(){
		
		//deactivateOnce = true;
		bossSpawn.SetActive (true);
		normSpawn.SetActive (false);

		yield return new WaitForSeconds (6f);


		isRolling = true;

		yield return new WaitForSeconds (2f);

		spamActive = true;

		tapTapReady = true;

		Handheld.Vibrate();

		//yield return new WaitForSeconds (Random.Range(25f,35f));
		//rollOnce = true;
		//isRolling = true;



	}

	IEnumerator waitDeath (){
		
		yield return new WaitForSeconds (8f);
		if (isRolling) {

			tapTapReady = false;

			StartCoroutine (waitDeathFinal ());


			isDeadByLavine = true;
		}
	
	}
	IEnumerator waitDeathFinal(){
		
		lavineDeathParticle.Play ();
		yield return new WaitForSeconds (0.5f);

		tapTapReady = false;

		destroyBot.dieBool = true;
		lavineDeathParticle.Play ();
		Handheld.Vibrate ();

	
	}
	/*IEnumerator waitForRollStart(){

		//deactivateOnce = true;
		yield return new WaitForSeconds (Random.Range(25f,30f));





		bossSpawn.SetActive (true);
		normSpawn.SetActive (false);

		yield return new WaitForSeconds (8f);


		isRolling = true;


		yield return new WaitForSeconds (2f);

		spamActive = true;


		//yield return new WaitForSeconds (Random.Range(25f,35f));
		//rollOnce = true;
		//isRolling = true;



	}*/
	IEnumerator vibrateNum(){


		yield return new WaitForSeconds (0.6f);


		Handheld.Vibrate ();



		//if(isRolling)StartCoroutine (vibrateNum ());

	}

	IEnumerator setRollingTrue(){
	
		tapTapReady = false;
		pc2D.feedbackOnce = true;
		pc2D.feedbackOnceTwo = true;
		yield return new WaitForSeconds (3f);
		feedbackTextObj.GetComponent<TextMesh> ().color = new Color (1f,1f,1f, 1f);

		if (lavineTest) {
			yield return new WaitForSeconds (0f);
		} else {
			yield return new WaitForSeconds (Random.Range (25f, 35f));
		}
		rollOnce = true;



		StartCoroutine (waitForRoll ());


		//isRolling = true;

	
	}



}
