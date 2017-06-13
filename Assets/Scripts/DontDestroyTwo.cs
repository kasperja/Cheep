using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyTwo : MonoBehaviour {

	// Use this for initialization
	public bool audioFadeOut = false;
	private Scene currentScene; 
	public static DontDestroyTwo instanceTwo;

	public PlatformerCharacter2D pc2D;

	private bool musicDisabled = false;

	public RotateCam rCam;
	public AudioSource music;
	public AudioSource introGame;
	public AudioSource levelOne;
	public AudioSource levelTwo;
	public AudioSource levelThree;
	public AudioSource dangerOne;
	public AudioSource dangerTwo;
	public AudioSource dangerThree;
	public AudioSource crash1;
	public AudioSource crash2;
	public AudioSource crash3;
	public AudioSource crash4;
	public AudioSource crash5;

	public float randomCrash = 0f;

	private bool introOnce = true;

//	public LavineMove lavineScript;
	private float bossCount = 1f;

	public bool dangerOnce = true;
	public bool levelOnce = true;
	public bool levelOnceFinal = true;
	public bool levelOnceFinalTwo = true;

	private bool shiftReady = false;
	private bool shiftReadyTwo = false;
	private bool shiftReadyThree = false;

	private bool normShiftReady = false;
	private bool normShiftReady2 = false;
	private bool normShiftReady3 = false;


	public bool isRollingMusic = false;

	private bool dieOnce = true;
	private bool dangerIncreaseOnce = true;
	private bool increaseVolDanger = false;
	private bool decreaseVolDanger = true;

	public float pointInTime = 0f;

	void Awake(){

		//lavineScript = GameObject.Find ("Lavine").GetComponent<LavineMove>();

		introOnce = true;

		MusicDisable ();
		
		//DontDestroyOnLoad (gameObject);

		if (instanceTwo == null) {

			instanceTwo = this;

		} else {

			Destroy (this.gameObject);
			return;

		}

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			//DontDestroyOnLoad (gameObject);
			//gameObject.GetComponent<AudioSource> ().Play ();
			Debug.Log ("Scene 1");
			audioFadeOut = true;

		}
		if (currentScene.name == "StartScene") {

			//DontDestroyOnLoad (gameObject);
			//audioFadeOut = true;
			Debug.Log ("Scene 1");
			audioFadeOut = true;

		}
		if (currentScene.name == "Scene01") {

			//DontDestroyOnLoad (gameObject);
			gameObject.GetComponent<AudioSource> ().Play ();


		}

	}
	// Use this for initialization
	void Start () {


		introOnce = true;




		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		Scene currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}

	}

	// Update is called once per frame
	void Update () {

		if (increaseVolDanger) {
		
			dangerOne.volume += 1f * Time.deltaTime;
			dangerTwo.volume += 1f * Time.deltaTime;
			dangerThree.volume += 1f * Time.deltaTime;

		
		} else {
		
			dangerOne.volume -= 1f * Time.deltaTime;
			dangerTwo.volume -= 1f * Time.deltaTime;
			dangerThree.volume -= 1f * Time.deltaTime;
		
		}

		if (pc2D.isDead && dieOnce) {
		
			randomCrash = Random.Range (0f, 5f);

			music.Stop ();
			dangerOne.Stop ();
			dangerTwo.Stop ();
			dangerThree.Stop ();
			if (randomCrash <= 1f) {
				crash1.Play ();
			} else if (randomCrash <= 2f) {
				crash2.Play ();
			}else if (randomCrash <= 3f) {
				crash3.Play ();
			}else if (randomCrash <= 4f) {
				crash4.Play ();
			}else if (randomCrash <= 5f) {
				crash5.Play ();
			}
		
			dieOnce = false;

		}

		if (introGame.time >= 2.4f && introOnce) {
		
			music.Stop ();
			music = levelOne;
			music.Play ();
			introOnce = false;
			StopCoroutine(musicIntervals ());
			StartCoroutine (musicIntervals ());
		
		}

		if (/*bossCount == 2f &&*/ !isRollingMusic && levelOnce && shiftReady && (rCam.shiftMusicTo2|| rCam.shiftMusicTo1)) {
		
			music.Stop ();
			music = levelTwo;
			music.Play ();
			//dangerOne.Stop ();
			StopCoroutine(musicIntervalsTwo ());
			StartCoroutine (musicIntervalsTwo ());
			increaseVolDanger = false;
			dangerIncreaseOnce = true;
			levelOnce = false;

		}

		if (/*bossCount == 3f && */!isRollingMusic && levelOnceFinal && shiftReadyTwo && rCam.shiftMusicTo3) {

			music.Stop ();
			music = levelThree;
			music.Play ();
			//dangerTwo.Stop ();
			//dangerThree.Stop ();
			StopCoroutine(musicIntervalsThree ());
			StartCoroutine (musicIntervalsThree ());
			increaseVolDanger = false;
			dangerIncreaseOnce = true;
			levelOnceFinal = false;

		} else if (/*bossCount == 3f && */!isRollingMusic && levelOnceFinal && shiftReadyThree && rCam.shiftMusicTo3) {

			//music.Stop ();
			//music = levelThree;
			//music.Play ();
			//dangerTwo.Stop ();
			//dangerThree.Stop ();
			//StartCoroutine (musicIntervalsThree ());
			increaseVolDanger = false;
			dangerIncreaseOnce = true;
			levelOnceFinal = false;

		}/* else if (bossCount == 3f && !isRollingMusic && levelOnceFinalTwo) {

			music.Stop ();
			music = levelThree;
			music.Play ();
			dangerThree.Stop ();
			StartCoroutine (musicIntervalsThree ());

			levelOnceFinalTwo = false;

		}*/

		if (isRollingMusic /*&& bossCount == 1f*/ && dangerOnce && shiftReady && rCam.shiftMusicTo1) {


			if (dangerIncreaseOnce) {
				dangerOne.volume = 0f;
				dangerIncreaseOnce = false;
			}
			dangerOne.Play();
			dangerTwo.Stop ();
			dangerThree.Stop ();
			increaseVolDanger = true;
			dangerOne.time = music.time;
			dangerOnce = false;
			levelOnce = true;
			levelOnceFinal = true;
			levelOnceFinalTwo = true;
			bossCount = 2f;

		
		} 

		if (isRollingMusic /*&& bossCount == 2f*/ && dangerOnce && shiftReadyTwo && rCam.shiftMusicTo2) {
		
			if (dangerIncreaseOnce) {
				dangerOne.volume = 0f;
				dangerIncreaseOnce = false;
			}
			dangerTwo.Play();
			dangerOne.Stop ();
			dangerThree.Stop ();
			increaseVolDanger = true;
			dangerTwo.time = music.time;
			dangerOnce = false;
			levelOnce = true;
			levelOnceFinal = true;
			levelOnceFinalTwo = true;
			bossCount = 3f;
		
		} 

		if (isRollingMusic /*&& bossCount == 3f*/ && dangerOnce && shiftReadyThree && rCam.shiftMusicTo3) {
		
			if (dangerIncreaseOnce) {
				dangerOne.volume = 0f;
				dangerIncreaseOnce = false;
			}
			dangerThree.Play ();
			dangerOne.Stop ();
			dangerTwo.Stop ();
			increaseVolDanger = true;

			dangerThree.time = music.time;
			dangerOnce = false;
			bossCount = 3f;
			levelOnce = true;
			levelOnceFinal = true;
			levelOnceFinalTwo = true;

		}



		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "GameOverScene") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = true;


		}

		if (currentScene.name == "Scene01") {

			//StartCoroutine (waitAndDestroy ());

			audioFadeOut = false;


		}

		if (musicDisabled) {

			music.volume = 0f;
			introGame.volume = 0f;
			levelOne.volume = 0f;
			levelTwo.volume = 0f;
			levelThree.volume = 0f;
			dangerOne.volume = 0f;
			dangerTwo.volume = 0f;
			dangerThree.volume = 0f;
			crash1.volume = 0f;
			crash2.volume = 0f;
			crash3.volume = 0f;
			crash4.volume = 0f;
			crash5.volume = 0f;


			//ES2.Save (musicDisabled, "musicDisabled");

		}else if (audioFadeOut && !musicDisabled) {

			if(music.volume > 0f)music.volume -= 1f * Time.deltaTime;

		} else if(!musicDisabled) {

			if(music.volume < 0.6f)music.volume += 1f * Time.deltaTime;

		}
	}

	public void MusicDisable () {

		music = introGame;

		//music = gameObject.GetComponent<AudioSource> ();

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		if (musicDisabled) {

			music.volume = 0f;;

		} else {

			music.volume = 0.6f;

		}
		//ES2.Save (musicDisabled, "musicDisabled");

	}

	IEnumerator waitAndDestroy(){

		yield return new WaitForSeconds (1f);

		Destroy (this.gameObject);

	}

	IEnumerator musicIntervals(){
	


		yield return new WaitForSeconds (1.2f);
		pointInTime += 1f;

		shiftReady = true;


		StartCoroutine (intervalShiftFalse ());
		StartCoroutine (musicIntervals ());

	}

	IEnumerator musicIntervalsTwo(){



		yield return new WaitForSeconds (1.091f);

		pointInTime += 1f;

		shiftReadyTwo = true;


		StartCoroutine (intervalShiftFalse ());
		StartCoroutine (musicIntervalsTwo ());

	}

	IEnumerator musicIntervalsThree(){



		yield return new WaitForSeconds (1f);

		pointInTime += 1f;

		shiftReadyThree = true;


		StartCoroutine (intervalShiftFalse ());
		StartCoroutine (musicIntervalsThree ());

	}

	IEnumerator intervalShiftFalse(){
	
		yield return new WaitForSeconds (0.1f);
		shiftReady = false;
		shiftReadyTwo = false;
		shiftReadyThree = false;

	
	}

}
