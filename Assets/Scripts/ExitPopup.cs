using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopup : MonoBehaviour {
	public AudioSource buttonSound;
	public GameObject popup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ExitPopupScreen(){
		
		buttonSound.Play ();
		popup.SetActive (false);
	
	}
}
