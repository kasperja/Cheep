using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopup : MonoBehaviour {

	public GameObject popup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ExitPopupScreen(){
	
		popup.SetActive (false);
	
	}
}
