using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) /*|| (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began*/) {

			Application.LoadLevel (1);

		}
		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}
	
		if(Input.GetKeyDown (KeyCode.O))ES2.DeleteDefaultFolder();

	}

	public void Retry(){

		Application.LoadLevel (1);

	}


}
