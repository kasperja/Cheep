using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyTwo : MonoBehaviour {

	// Use this for initialization
	public bool audioFadeOut = false;
	private Scene currentScene; 
	public static DontDestroyTwo instanceTwo;

	void Awake(){
		
		DontDestroyOnLoad (gameObject);

		if (instanceTwo == null) {

			instanceTwo = this;

		} else {

			Destroy (this.gameObject);
			return;

		}

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			DontDestroyOnLoad (gameObject);
			//gameObject.GetComponent<AudioSource> ().Play ();
			Debug.Log ("Scene 1");
			audioFadeOut = true;

		}
		if (currentScene.name == "StartScene") {

			DontDestroyOnLoad (gameObject);
			//audioFadeOut = true;
			Debug.Log ("Scene 1");
			audioFadeOut = true;

		}
		if (currentScene.name == "Scene01") {

			DontDestroyOnLoad (gameObject);
			gameObject.GetComponent<AudioSource> ().Play ();


		}

	}
	// Use this for initialization
	void Start () {

		Scene currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}

	}

	// Update is called once per frame
	void Update () {

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}

		if (currentScene.name == "Scene01") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = false;


		}

		if (audioFadeOut) {

			if(gameObject.GetComponent<AudioSource> ().volume > 0f)gameObject.GetComponent<AudioSource> ().volume -= 1f * Time.deltaTime;

		} else {

			if(gameObject.GetComponent<AudioSource> ().volume < 1f)gameObject.GetComponent<AudioSource> ().volume += 1f * Time.deltaTime;

		}
	}

	IEnumerator waitAndDestroy(){

		yield return new WaitForSeconds (1f);

		Destroy (this.gameObject);

	}
}
