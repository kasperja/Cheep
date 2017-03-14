using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	public FadeOut fadeOutScript;
	// Use this for initialization
	void Start () {
	
	}
	void Awake(){
		
		//Application.targetFrameRate = 60;
	
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) /*|| (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began*/) {

			Retry ();

		}
		/*if (Input.GetKey ("escape")) {
			Application.Quit ();
		}*/
	
		if(Input.GetKeyDown (KeyCode.O))ES2.DeleteDefaultFolder();

	}

	public void Retry(){

		StartCoroutine (retryNum ());

	}

	IEnumerator retryNum (){

		fadeOutScript.isStarted = true;
		yield return new WaitForSeconds (1f);
		Application.LoadLevel (1);



	}


}
