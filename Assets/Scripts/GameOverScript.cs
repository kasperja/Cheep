using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

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

	public Text finalScoreTxt;

	public Text yourRecordIsTxt;

	//public Text highScoreTxt;

	public AudioSource click;

	public AudioSource music;
	private bool musicBool = false;

	void Start () {

		yourRecordIsTxt.gameObject.SetActive (false);
		//highScoreTxt.gameObject.SetActive (false);
		
		if (ES2.Exists ("myCurrentScore")) {

			score = ES2.Load<int> ("myCurrentScore");

		}



			if(ES2.Exists("myHighscore"))highscore = ES2.Load<int> ("myHighscore");
			if(ES2.Exists("myHighscore2"))highscore2 = ES2.Load<int> ("myHighscore2");
			if(ES2.Exists("myHighscore3"))highscore3 = ES2.Load<int> ("myHighscore3");
			if(ES2.Exists("myHighscore4"))highscore4 = ES2.Load<int> ("myHighscore4");
			if(ES2.Exists("myHighscore5"))highscore5 = ES2.Load<int> ("myHighscore5");
			if(ES2.Exists("myHighscore6"))highscore6 = ES2.Load<int> ("myHighscore6");
			if(ES2.Exists("myHighscore7"))highscore7 = ES2.Load<int> ("myHighscore7");
			if(ES2.Exists("myHighscore8"))highscore8 = ES2.Load<int> ("myHighscore8");
			if(ES2.Exists("myHighscore9"))highscore9 = ES2.Load<int> ("myHighscore9");
			if(ES2.Exists("myHighscore10"))highscore10 = ES2.Load<int> ("myHighscore10");

			if (score > highscore) {

				yourScoreIsTxt.text = "It's a new record!";

				highscore = score;

				ES2.Save (score, "myHighscore");



			} else if(score > highscore2 && score <= highscore){



				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;
				highscore4 = highscore3;
				highscore3 = highscore2;

				highscore2 = score;

				ES2.Save (score, "myHighscore2");
				ES2.Save (score, "myHighscore3");
				ES2.Save (score, "myHighscore4");
				ES2.Save (score, "myHighscore5");
				ES2.Save (score, "myHighscore6");
				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");



			}else if(score > highscore3 && score <= highscore2){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;
				highscore4 = highscore3;

				highscore3 = score;

				ES2.Save (score, "myHighscore3");
				ES2.Save (score, "myHighscore4");
				ES2.Save (score, "myHighscore5");
				ES2.Save (score, "myHighscore6");
				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");



			}else if(score > highscore4 && score <= highscore3){


				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;
				highscore5 = highscore4;

				highscore4 = score;

				ES2.Save (score, "myHighscore4");
				ES2.Save (score, "myHighscore5");
				ES2.Save (score, "myHighscore6");
				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");


			}else if(score > highscore5 && score <= highscore4){


				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;
				highscore6 = highscore5;

				highscore5 = score;

				ES2.Save (score, "myHighscore5");
				ES2.Save (score, "myHighscore6");
				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");


			}else if(score > highscore6 && score <= highscore5){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;
				highscore7 = highscore6;

				highscore6 = score;

				ES2.Save (score, "myHighscore6");
				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");



			}else if(score > highscore7 && score <= highscore6){

				highscore10 = highscore9;
				highscore9 = highscore8;
				highscore8 = highscore7;

				highscore7 = score;

				ES2.Save (score, "myHighscore7");
				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");

			}else if(score > highscore8 && score <= highscore7){

				highscore10 = highscore9;
				highscore9 = highscore8;

				highscore8 = score;

				ES2.Save (score, "myHighscore8");
				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");


			}else if(score > highscore9 && score <= highscore8){

				highscore10 = highscore9;

				highscore9 = score;

				ES2.Save (score, "myHighscore9");
				ES2.Save (score, "myHighscore10");


			}else if(score > highscore10 && score <= highscore9){

				highscore10 = score;

				ES2.Save (score, "myHighscore10");


			}else {
			
				yourRecordIsTxt.gameObject.SetActive (true);
				//highScoreTxt.gameObject.SetActive (true);
				yourRecordIsTxt.text = "Your record is:   " + highscore;
				//highScoreTxt.text = "" + highscore; 

			}



			







		//score = PlayerPrefs.GetInt ("Score");

		finalScoreTxt.text = "" + score;

	}
	void Update(){

		if(Input.GetKeyDown (KeyCode.O))ES2.DeleteDefaultFolder();
	
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) || (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began) {
		
			click.Play ();
			StartCoroutine (waitAndRestart());

		}
		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}

		if(musicBool){


			music.volume -= 2f * Time.deltaTime;
		}
	
	}


	public void Retry(){
	
		click.Play ();
		StartCoroutine (waitAndRestart());
	
	}

	IEnumerator waitAndRestart(){
		
		musicBool = true;
		//yield return new WaitForSeconds (0.5f);
		Application.LoadLevel (0);
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
