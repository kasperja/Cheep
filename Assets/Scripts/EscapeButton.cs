using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeButton : MonoBehaviour {

	public AudioSource buttonSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void QuitPressed(){
	
		buttonSound.Play ();
		Application.Quit();
	
	}
}
