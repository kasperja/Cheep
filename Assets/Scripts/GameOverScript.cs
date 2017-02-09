using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	public int highscore = 0;

	public Text finalScoreTxt;

	public AudioSource click;

	public AudioSource music;
	private bool musicBool = false;

	void Start () {
		
		if (ES2.Exists ("myCurrentScore")) {

			score = ES2.Load<int> ("myCurrentScore");

		}

		if(ES2.Exists("myHighscore")){

			highscore = ES2.Load<int> ("myHighscore");

			if (score > highscore) {

				highscore = score;
				ES2.Save (score, "myHighscore");

			}


		}
			







		//score = PlayerPrefs.GetInt ("Score");

		finalScoreTxt.text = "" + score;

	}
	void Update(){
	
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
