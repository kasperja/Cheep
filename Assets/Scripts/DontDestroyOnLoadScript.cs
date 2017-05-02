using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoadScript : MonoBehaviour {

	public bool audioFadeOut = false;
	private Scene currentScene; 
	public static DontDestroyOnLoadScript instance;
	private bool musicDisabled = false;

	public AudioSource music;

	void Awake(){

		MusicDisable ();

		if (instance == null) {
		
			instance = this;
		
		} else {
		
			Destroy (this.gameObject);
			return;
		
		}

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {
		
			//DontDestroyOnLoad (gameObject);
			//gameObject.GetComponent<AudioSource> ().Play ();
		
		}
		if (currentScene.name == "StartScene") {

			DontDestroyOnLoad (gameObject);
			gameObject.GetComponent<AudioSource> ().Play ();
			//audioFadeOut = true;

		}
		if (currentScene.name == "CharScene") {

			DontDestroyOnLoad (gameObject);
			gameObject.GetComponent<AudioSource> ().Play ();
			//audioFadeOut = true;

		}
		if (currentScene.name == "Scene01") {
		
			Debug.Log ("Scene 1");
			audioFadeOut = true;

		
		}
	
	}
	// Use this for initialization
	void Start () {

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		Scene currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "Scene01") {

			StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "Scene01") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}

		if (currentScene.name == "GameOverScene") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = false;


		}

		if (musicDisabled) {

			gameObject.GetComponent<AudioSource> ().volume = 0f;

			//ES2.Save (musicDisabled, "musicDisabled");

		}else if (audioFadeOut || musicDisabled) {
		
			if(gameObject.GetComponent<AudioSource> ().volume > 0f)gameObject.GetComponent<AudioSource> ().volume -= 1f * Time.deltaTime;
		
		} else if(!musicDisabled) {
		
			if(gameObject.GetComponent<AudioSource> ().volume < 1f)gameObject.GetComponent<AudioSource> ().volume += 1f * Time.deltaTime;
		
		}
	}

	public void MusicDisable () {

		music = gameObject.GetComponent<AudioSource> ();

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		if (musicDisabled) {

			music.volume = 0f;;

		} else {

			music.volume = 1f;

		}
		//ES2.Save (musicDisabled, "musicDisabled");

	}

	IEnumerator waitAndDestroy(){
	
		yield return new WaitForSeconds (1f);

		Destroy (this.gameObject);
	
	}
}
