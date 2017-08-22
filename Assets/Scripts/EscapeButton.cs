using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour {

	public AudioSource buttonSound;
    private bool isFirstStart = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void QuitPressed(){
	
		StartCoroutine (QuitNum ());

	
	}

	IEnumerator QuitNum(){

        isFirstStart = true;
        ES2.Save(isFirstStart, "firstStart");
        buttonSound.Play ();
		yield return new WaitForSeconds (0.3f);
		Application.Quit();
		//yield return null;
	
	}
}
