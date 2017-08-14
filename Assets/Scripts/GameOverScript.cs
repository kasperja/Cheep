using UnityEngine;
using UnityEngine.UI;
using System.Collections;
#if UNITY_IOS
using UnityEngine.Advertisements;
#endif
#if UNITY_ANDROID
using UnityEngine.Advertisements;
#endif




public class GameOverScript : MonoBehaviour {

	int score = 0;

    public GameObject getReadyObj;

	private int countPlays = 0;
	private bool showAdCount = false;

	public int highscore = 0;
	public int highscore2 = 0;
	public int highscore3 = 0;
	public int highscore4 = 0;
	public int highscore5 = 0;
	public int highscore6 = 0;
	public int highscore7 = 0;
	public int highscore8 = 0;
	public int highscore9 = 0;
	public int highscore10 = 0;

	public Text yourScoreIsTxt;
	public Text yourScoreIsTxt2;
	public Text yourScoreIsTxt3;

	public Text finalScoreTxt;
	public Text finalScoreTxt2;
	public Text finalScoreTxt3;
	public Text finalScoreTxt4;
	public Text finalScoreTxt5;
	public Text finalScoreTxt6;
	public Text finalScoreTxt7;
	public Text finalScoreTxt8;
	public Text finalScoreTxt9;
	public Text finalScoreTxt10;

	//public GameObject charUnlockObj;


	public Text yourRecordIsTxt;

	//public Text highScoreTxt;

	public AudioSource click;


	public AudioSource music;
	private bool musicBool = false;

	private bool adsDone = false;

	public bool disableAds = false;

	public ParticleSystem konfettiParticle;
	public AudioSource applause;
    public AudioSource rewardSound;

    public FadeIn fadeOutScript;
	private bool isQuickRestart = false;


	private bool char1UnlockedPointsOnce = true;
	private bool char2UnlockedPointsOnce = true;
	private bool char3UnlockedPointsOnce = true;
	private bool char4UnlockedPointsOnce = true;
	private bool char5UnlockedPointsOnce = true;
	private bool char6UnlockedPointsOnce = true;
	private bool char7UnlockedPointsOnce = true;
	private bool char8UnlockedPointsOnce = true;

	/*public GameObject char1pic;
	public GameObject char2pic;
	public GameObject char3pic;
	public GameObject char4pic;
	public GameObject char5pic;
	public GameObject char6pic;
	public GameObject char7pic;
	public GameObject char8pic;
*/
	public GameObject tryButton;


	//public GameObject noAdsButton;


	void Awake(){

		//Application.targetFrameRate = 60;

	}

	void Start () {

		if (ES2.Exists ("noAds")) {

			disableAds =  ES2.Load<bool>( "noAds");
		}

		if (ES2.Exists ("countPlays")) {

			countPlays =  ES2.Load<int>( "countPlays");
		}

		countPlays += 1;

		ES2.Save (countPlays, "countPlays");

		if (countPlays >= 3) {

			showAdCount = true;

			countPlays = 0;
		
			ES2.Save (countPlays, "countPlays");

		} else {
		
			showAdCount = false;
		
		}





		if (!ES2.Exists ("myCurrentScore")) {

			yourScoreIsTxt.gameObject.SetActive (false);

			//charUnlockObj.SetActive (false);

			//char1pic.SetActive (false);
			//char2pic.SetActive (false);
			//char3pic.SetActive (false);
			//char4pic.SetActive (false);
			//char5pic.SetActive (false);
			//char6pic.SetActive (false);
			//char7pic.SetActive (false);
			//char8pic.SetActive (false);


			//noAdsButton.SetActive (false);
		}





		finalScoreTxt.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt2.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt3.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt4.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt5.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt6.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt7.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt8.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt9.gameObject.GetComponent<TextFader> ().enabled = false;
		finalScoreTxt10.gameObject.GetComponent<TextFader> ().enabled = false;


		yourRecordIsTxt.gameObject.SetActive (false);
		//highScoreTxt.gameObject.SetActive (false);
		
		if (ES2.Exists ("myCurrentScore")) {

			score = ES2.Load<int> ("myCurrentScore");

			/*

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

			if (char8UnlockedPointsOnce && score >= 40000) {

				charUnlockObj.SetActive (true);

				char8UnlockedPointsOnce = false;

				char8pic.SetActive (true);

				ES2.Save (char8UnlockedPointsOnce, "char8Unlock");

			}else if (char7UnlockedPointsOnce && score >= 35000) {

				charUnlockObj.SetActive (true);

				char7UnlockedPointsOnce = false;

				char7pic.SetActive (true);

				ES2.Save (char7UnlockedPointsOnce, "char7Unlock");

			}else if (char6UnlockedPointsOnce && score >= 30000) {

				charUnlockObj.SetActive (true);

				char6UnlockedPointsOnce = false;

				char6pic.SetActive (true);


				ES2.Save (char6UnlockedPointsOnce, "char6Unlock");

			} else if (char5UnlockedPointsOnce && score >= 25000) {

				charUnlockObj.SetActive (true);

				char5UnlockedPointsOnce = false;

				char5pic.SetActive (true);

				ES2.Save (char5UnlockedPointsOnce, "char5Unlock");

			} else if (char4UnlockedPointsOnce && score >= 20000) {

				charUnlockObj.SetActive (true);

				char4UnlockedPointsOnce = false;

				char4pic.SetActive (true);

				ES2.Save (char4UnlockedPointsOnce, "char4Unlock");

			}else if (char3UnlockedPointsOnce && score >= 15000) {

				charUnlockObj.SetActive (true);

				char3UnlockedPointsOnce = false;

				char3pic.SetActive (true);

				ES2.Save (char3UnlockedPointsOnce, "char3Unlock");

			} else if (char2UnlockedPointsOnce && score >= 10000) {

				charUnlockObj.SetActive (true);

				char2UnlockedPointsOnce = false;

				char2pic.SetActive (true);

				ES2.Save (char2UnlockedPointsOnce, "char2Unlock");

			}else if (char1UnlockedPointsOnce && score >= 5000) {

				charUnlockObj.SetActive (true);

				char1UnlockedPointsOnce = false;

				char1pic.SetActive (true);

				ES2.Save (char1UnlockedPointsOnce, "char1Unlock");

			}

*/

		}



			if (ES2.Exists ("myHighscore"))highscore = ES2.Load<int> ("myHighscore");
			if(ES2.Exists("myHighscore2"))highscore2 = ES2.Load<int> ("myHighscore2");
			if(ES2.Exists("myHighscore3"))highscore3 = ES2.Load<int> ("myHighscore3");
			if(ES2.Exists("myHighscore4"))highscore4 = ES2.Load<int> ("myHighscore4");
			if(ES2.Exists("myHighscore5"))highscore5 = ES2.Load<int> ("myHighscore5");
			if(ES2.Exists("myHighscore6"))highscore6 = ES2.Load<int> ("myHighscore6");
			if(ES2.Exists("myHighscore7"))highscore7 = ES2.Load<int> ("myHighscore7");
			if(ES2.Exists("myHighscore8"))highscore8 = ES2.Load<int> ("myHighscore8");
			if(ES2.Exists("myHighscore9"))highscore9 = ES2.Load<int> ("myHighscore9");
			if(ES2.Exists("myHighscore10"))highscore10 = ES2.Load<int> ("myHighscore10");

			if (score >= highscore) {

			if (ES2.Exists ("myCurrentScore")) {
				applause.Play ();
                rewardSound.Play();
				konfettiParticle.Play ();
				yourScoreIsTxt.text = "It's a new record!";
			}
				

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;
				highscore4 = highscore3;
				highscore3 = highscore2;
				highscore2 = highscore;

				highscore = score;

			ES2.Save (highscore, "myHighscore");
			ES2.Save (highscore2, "myHighscore2");
			ES2.Save (highscore3, "myHighscore3");
			ES2.Save (highscore4, "myHighscore4");
			ES2.Save (highscore5, "myHighscore5");
			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt.gameObject.GetComponent<TextFader> ().enabled = true;


			} else if(score > highscore2 && score < highscore){



				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;
				highscore4 = highscore3;
				highscore3 = highscore2;

				highscore2 = score;


			ES2.Save (highscore2, "myHighscore2");
			ES2.Save (highscore3, "myHighscore3");
			ES2.Save (highscore4, "myHighscore4");
			ES2.Save (highscore5, "myHighscore5");
			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt2.gameObject.GetComponent<TextFader> ().enabled = true;


			}else if(score > highscore3 && score <= highscore2){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;
				highscore4 = highscore3;

				highscore3 = score;


			ES2.Save (highscore3, "myHighscore3");
			ES2.Save (highscore4, "myHighscore4");
			ES2.Save (highscore5, "myHighscore5");
			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt3.gameObject.GetComponent<TextFader> ().enabled = true;

			}else if(score > highscore4 && score <= highscore3){


				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;

				highscore4 = score;


			ES2.Save (highscore4, "myHighscore4");
			ES2.Save (highscore5, "myHighscore5");
			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt4.gameObject.GetComponent<TextFader> ().enabled = true;

			}else if(score > highscore5 && score <= highscore4){


				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;

				highscore5 = score;


			ES2.Save (highscore5, "myHighscore5");
			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt5.gameObject.GetComponent<TextFader> ().enabled = true;


			}else if(score > highscore6 && score <= highscore5){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;

				highscore6 = score;


			ES2.Save (highscore6, "myHighscore6");
			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt6.gameObject.GetComponent<TextFader> ().enabled = true;

			}else if(score > highscore7 && score <= highscore6){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;

				highscore7 = score;


			ES2.Save (highscore7, "myHighscore7");
			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt7.gameObject.GetComponent<TextFader> ().enabled = true;

			}else if(score > highscore8 && score <= highscore7){

				highscore10 = highscore9;
				highscore9 = highscore8;

				highscore8 = score;


			ES2.Save (highscore8, "myHighscore8");
			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt8.gameObject.GetComponent<TextFader> ().enabled = true;


			}else if(score > highscore9 && score <= highscore8){

				highscore10 = highscore9;

				highscore9 = score;


			ES2.Save (highscore9, "myHighscore9");
			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt9.gameObject.GetComponent<TextFader> ().enabled = true;


			}else if(score > highscore10 && score <= highscore9){

				highscore10 = score;


			ES2.Save (highscore10, "myHighscore10");

			finalScoreTxt10.gameObject.GetComponent<TextFader> ().enabled = true;


			}else {
			
				yourRecordIsTxt.gameObject.SetActive (false);
				//highScoreTxt.gameObject.SetActive (true);
				yourRecordIsTxt.text = "Your record is:   " + highscore;
				//highScoreTxt.text = "" + highscore; 

			}



		if (ES2.Exists ("myCurrentScore")) {
			
			yourScoreIsTxt3.gameObject.SetActive (false);
			yourScoreIsTxt.text = "  " + score;

		} else {
			yourScoreIsTxt.gameObject.SetActive (false);
			yourScoreIsTxt2.gameObject.SetActive (false);
			yourScoreIsTxt3.gameObject.SetActive (true);
		
		}







		//score = PlayerPrefs.GetInt ("Score");

		if (highscore == 0)
			finalScoreTxt.text = "";

		finalScoreTxt.text = "" + highscore;
		finalScoreTxt2.text = "" + highscore2;
		finalScoreTxt3.text = "" + highscore3;
		finalScoreTxt4.text = "" + highscore4;
		finalScoreTxt5.text = "" + highscore5;
		finalScoreTxt6.text = "" + highscore6;
		finalScoreTxt7.text = "" + highscore7;
		finalScoreTxt8.text = "" + highscore8;
		finalScoreTxt9.text = "" + highscore9;
		finalScoreTxt10.text = "" + highscore10;

		if (highscore == 0)
			finalScoreTxt.text = "";
		if (highscore2 == 0)
			finalScoreTxt2.text = "";
		if (highscore3 == 0)
			finalScoreTxt3.text = "";
		if (highscore4 == 0)
			finalScoreTxt4.text = "";
		if (highscore5 == 0)
			finalScoreTxt5.text = "";
		if (highscore6 == 0)
			finalScoreTxt6.text = "";
		if (highscore7 == 0)
			finalScoreTxt7.text = "";
		if (highscore8 == 0)
			finalScoreTxt8.text = "";
		if (highscore9 == 0)
			finalScoreTxt9.text = "";
		if (highscore10 == 0)
			finalScoreTxt10.text = "";

		if(highscore == 0)tryButton.SetActive (false);
		if(highscore > 0)tryButton.SetActive (true);
	}

	void Update(){

		if(Input.GetKeyDown (KeyCode.O))ES2.DeleteDefaultFolder();
	
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) /*|| (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began*/) {
		
			click.Play ();
			isQuickRestart = true;
			StartCoroutine (waitAndRestart());

		}
		/*if (Input.GetKey ("escape")) {
			Application.Quit ();
		}*/

		if ((adsDone

#if UNITY_IOS
&& !Advertisement.isShowing
#endif
#if UNITY_ANDROID
&& !Advertisement.isShowing
#endif


            )) {
			
			if (isQuickRestart) {
                getReadyObj.SetActive(true);
				Application.LoadLevel (1);
			} else {
			
				Application.LoadLevel (0);
			
			}
		
		}

		if(musicBool){


			//music.volume -= 2f * Time.deltaTime;
		}
	
	}


	public void Retry(){

		//click.Play ();
		isQuickRestart = false;
		StartCoroutine (waitAndRestart());
	
	}
	public void RetryQuick(){

		//click.Play ();
		isQuickRestart = true;
		StartCoroutine (waitAndRestart());

	}
	IEnumerator waitAndRestart(){

		//fadeOutScript.isEnded = true;
		//fadeOutScript.isStarted = false;
		//yield return new WaitForSeconds (0.25f);

		musicBool = true;
        //yield return new WaitForSeconds (0.5f);


#if UNITY_IOS
        if(!disableAds && ES2.Exists ("myCurrentScore") && showAdCount)Advertisement.Show ();
#endif
#if UNITY_ANDROID
        if (!disableAds && ES2.Exists("myCurrentScore") && showAdCount) Advertisement.Show();
#endif





        if (isQuickRestart) {
			
			fadeOutScript.isStarted = true;
			//fadeOutScript.isEnded = true;

			yield return new WaitForSeconds (0.5f);

		
		}

		if(countPlays >= 3)yield return new WaitForSeconds (2f);

		adsDone = true;
		//Application.LoadLevel (0);
		yield return null;
	
	}
	/*void OnGUI(){
	
		GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 - Screen.height * 0.1f, Screen.width * 0.2f, Screen.width * 0.2f), "GAME OVER");
		GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + Screen.height * 0.1f, Screen.width * 0.2f, Screen.width * 0.2f), "Score: " + score);

		if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2 + Screen.height * 0.1f, Screen.width * 0.02f, Screen.width * 0.02f), "Try again?")) {
		
			Application.LoadLevel (0);
		
		}
			
	}*/




}
