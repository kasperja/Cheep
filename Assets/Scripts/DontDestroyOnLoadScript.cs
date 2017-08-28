using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoadScript : MonoBehaviour {

	public bool audioFadeOut = false;
	private Scene currentScene; 
	public static DontDestroyOnLoadScript instance;
	private bool musicDisabled = false;

	public bool isIntro = true;
	public AudioSource music;
	public AudioSource musicIntro;
	public AudioSource musicLoop;
	public AudioSource musicEnd;

    public static bool endMenuMusic = false;
    private bool endOnce = true;

    private bool gameOverOnce = true;

    public int prevScene = 0;

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
			music.Play ();
			//audioFadeOut = true;

		}
		if (currentScene.name == "CharScene") {

			DontDestroyOnLoad (gameObject);
			music.Play ();
			//audioFadeOut = true;

		}
		if (currentScene.name == "Scene01") {
		
			Debug.Log ("Scene 1");
            endOnce = true;
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
            gameOverOnce = true;


		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (music.time >= 4f && isIntro) {

			music.Stop ();
			music = musicLoop;
			music.Play ();
			isIntro = false;


		}

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		currentScene = SceneManager.GetActiveScene();

        if (endMenuMusic && endOnce)
        {

            //StartCoroutine (waitAndDestroy ());
            music.Stop();
            musicEnd.Play();
            prevScene = 1;
            endOnce = false;
            
            //audioFadeOut = true;


        }

        /*if (currentScene.name == "Scene01") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}*/

        if (currentScene.name == "GameOverScene" && gameOverOnce && prevScene != 0) {

            audioFadeOut = false;
            //StartCoroutine (waitAndDestroy ());
            music = musicIntro;

            isIntro = true;

            if (!endMenuMusic)
            {

                music.Play();


            }
            else {

                music.Stop();

            }
            endOnce = true;
            gameOverOnce = false;


		}
        if (currentScene.name == "StartScene")
        {
            endMenuMusic = false;
            endOnce = true;
            prevScene = 0;


        }
        if (currentScene.name == "Scene01")
        {
            gameOverOnce = true;
            endMenuMusic = false;
            endOnce = true;
            prevScene = 1;


        }
        if (currentScene.name == "CharScene")
        {

            endMenuMusic = false;
            endOnce = true;
            prevScene = 3;


        }


        if (musicDisabled) {

			music.volume = 0f;
			music.volume = 0f;
			musicEnd.volume = 0f;
			musicLoop.volume = 0f;
			musicIntro.volume = 0f;

			//ES2.Save (musicDisabled, "musicDisabled");

		}else if (audioFadeOut || musicDisabled) {
		
			if(music.volume > 0f)music.volume -= 1f * Time.deltaTime;
			if(musicEnd.volume > 0f)musicEnd.volume -= 1f * Time.deltaTime;
			if(musicLoop.volume > 0f)musicLoop.volume -= 1f * Time.deltaTime;
			if(musicIntro.volume > 0f)musicIntro.volume -= 1f * Time.deltaTime;
		
		} else if(!musicDisabled) {
		
			if(music.volume < 1f)music.volume += 1f * Time.deltaTime;
			if(musicEnd.volume < 1f)musicEnd.volume += 1f * Time.deltaTime;
			if(musicLoop.volume < 1f)musicLoop.volume += 1f * Time.deltaTime;
			if(musicIntro.volume < 1f)musicIntro.volume += 1f * Time.deltaTime;


		
		}
	}

	public void MusicDisable () {

		//music = gameObject.GetComponent<AudioSource> ();

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		if (musicDisabled) {

			music.volume = 0f;
			musicEnd.volume = 0f;
			musicLoop.volume = 0f;
			musicIntro.volume = 0f;

		} else {

			music.volume = 1f;
			musicEnd.volume = 1f;
			musicLoop.volume = 1f;
			musicIntro.volume = 1f;

		}
		//ES2.Save (musicDisabled, "musicDisabled");

	}

	IEnumerator waitAndDestroy(){
	
		yield return new WaitForSeconds (1f);

		Destroy (this.gameObject);
	
	}
}
