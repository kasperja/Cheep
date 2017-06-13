﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnScriptUnlocker : MonoBehaviour {

	public GameObject[] obj;
	public HUDScript hud;
	//public PlatformerCharacter2D pc2D;

	public Text textPickup;

	public float scoreInterval = 1000f;
	public float multiplier = 1f;

	public float numberOfPickups = 0f;
	private float origNumberOfPickups = 0f;

	private bool startOnce = true;
	private bool startTextOnce = false;

	public float finalNumber = 5f;

	private bool char1UnlockedPointsOnce = false;
	private bool char2UnlockedPointsOnce = false;
	private bool char3UnlockedPointsOnce = false;
	private bool char4UnlockedPointsOnce = false;
	private bool char5UnlockedPointsOnce = false;
	private bool char6UnlockedPointsOnce = false;
	private bool char7UnlockedPointsOnce = false;
	private bool char8UnlockedPointsOnce = false;

	public bool char1UnlockedPointsOnceThisGame = false;
	public bool char2UnlockedPointsOnceThisGame = false;
	public bool char3UnlockedPointsOnceThisGame = false;
	public bool char4UnlockedPointsOnceThisGame = false;
	public bool char5UnlockedPointsOnceThisGame = false;
	public bool char6UnlockedPointsOnceThisGame = false;
	public bool char7UnlockedPointsOnceThisGame = false;
	public bool char8UnlockedPointsOnceThisGame = false;

	//public ObjectPoolManager objm;
	// Use this for initialization
	void Start () {



		if (ES2.Exists ("char1Unlock")) {

			char1UnlockedPointsOnce = ES2.Load<bool> ("char1Unlock");
		}

		if (ES2.Exists ("char2Unlock")) {

			char2UnlockedPointsOnce = ES2.Load<bool> ("char2Unlock");
		}

		if (ES2.Exists ("char3Unlock")) {

			char3UnlockedPointsOnce = ES2.Load<bool> ("char3Unlock");
		}

		if (ES2.Exists ("char4Unlock")) {

			char4UnlockedPointsOnce = ES2.Load<bool> ("char4Unlock");
		}

		if (ES2.Exists ("char5Unlock")) {

			char5UnlockedPointsOnce = ES2.Load<bool> ("char5Unlock");

		}

		if (ES2.Exists ("char6Unlock")) {

			char6UnlockedPointsOnce = ES2.Load<bool> ("char6Unlock");
		}

		if (ES2.Exists ("char7Unlock")) {

			char7UnlockedPointsOnce = ES2.Load<bool> ("char7Unlock");

		}

		if (ES2.Exists ("char8Unlock")) {

			char8UnlockedPointsOnce = ES2.Load<bool> ("char8Unlock");

		}


		//objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
		//Spawn ();

	}

	void Update(){

		if (!char5UnlockedPointsOnce) {
			
			if ((numberOfPickups > origNumberOfPickups) || startTextOnce) {
				textPickup.text = "" + (int)numberOfPickups + "/" + (int)finalNumber + " ";


				origNumberOfPickups = numberOfPickups;
				startTextOnce = false;
			}

		} else {
		
			textPickup.text = "";
		
		}
		if (hud.playerScore >= ( scoreInterval * multiplier)) {
			
			multiplier += 1f;
			Spawn ();
				


			//numberOfPickups += 1f;


			
		}
		if (char5UnlockedPointsOnce) {

			finalNumber = 30f;
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;
			
			}

		} else if (char4UnlockedPointsOnce) {

			finalNumber = 25f;
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;

			}

		} else if (char3UnlockedPointsOnce) {

			finalNumber = 20f;
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;

			}

		} else if (char2UnlockedPointsOnce) {

			finalNumber = 15f;
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;

			}

		} else if (char1UnlockedPointsOnce) {
		
			finalNumber = 10f;
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;

			}
		
		} else {
			if (startOnce) {

				startTextOnce = true;
				startOnce = false;

			}
		
		}






		if (numberOfPickups >= 5 && !char1UnlockedPointsOnce) {

			finalNumber = 10f;
			numberOfPickups = 0f;
			char1UnlockedPointsOnce = true;
			char1UnlockedPointsOnceThisGame = true;
			ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
			startTextOnce = true;

		}
		if (numberOfPickups >= 10 && char1UnlockedPointsOnce && !char2UnlockedPointsOnce) {

			finalNumber = 15f;
			numberOfPickups = 0f;
			char2UnlockedPointsOnce = true;
			char2UnlockedPointsOnceThisGame = true;
			ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
			startTextOnce = true;


		}
		if (numberOfPickups >= 15 && char1UnlockedPointsOnce && char2UnlockedPointsOnce && !char3UnlockedPointsOnce) {

			finalNumber = 20f;
			numberOfPickups = 0f;
			char3UnlockedPointsOnce = true;
			char3UnlockedPointsOnceThisGame = true;
			ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
			startTextOnce = true;


		}
		if (numberOfPickups >= 20 && char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && !char4UnlockedPointsOnce) {

			finalNumber = 25f;
			numberOfPickups = 0f;
			char4UnlockedPointsOnce = true;
			char4UnlockedPointsOnceThisGame = true;
			ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
			startTextOnce = true;


		}
		if (numberOfPickups >= 25 && char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && char4UnlockedPointsOnce && !char5UnlockedPointsOnce) {

			finalNumber = 30f;
			numberOfPickups = 0f;
			char5UnlockedPointsOnce = true;
			char5UnlockedPointsOnceThisGame = true;
			ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
			startTextOnce = true;


		}




	}

	public void Spawn(){

		if (!char1UnlockedPointsOnce) {
			
			Instantiate (obj [0],new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 1 spawn");

		} else if (char1UnlockedPointsOnce && !char2UnlockedPointsOnce) {
		
			Instantiate (obj [1], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 2 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && !char3UnlockedPointsOnce) {

			Instantiate (obj [2], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 3 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && !char4UnlockedPointsOnce) {

			Instantiate (obj [3], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 4 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && char4UnlockedPointsOnce &&  !char5UnlockedPointsOnce) {

			Instantiate (obj [4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 5 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && char4UnlockedPointsOnce && char5UnlockedPointsOnce && !char6UnlockedPointsOnce) {

			//Instantiate (obj [5], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 6 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && char4UnlockedPointsOnce && char5UnlockedPointsOnce && char6UnlockedPointsOnce && !char7UnlockedPointsOnce) {

			//Instantiate (obj [6], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 7 spawn");
		}else if (char1UnlockedPointsOnce && char2UnlockedPointsOnce && char3UnlockedPointsOnce && char4UnlockedPointsOnce && char5UnlockedPointsOnce && char6UnlockedPointsOnce && char7UnlockedPointsOnce && !char8UnlockedPointsOnce) {

			//Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
			Debug.Log ("p 8 spawn");
		}



	}



}

