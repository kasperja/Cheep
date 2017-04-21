using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour {

	private bool musicDisabled = false;

	//public MusicController mController;
	// Use this for initialization
	void Start () {

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisableMusic(){
	
		if (!musicDisabled) {
			
			musicDisabled = true;

		} else {
		
			musicDisabled = false;
		
		}
	
		ES2.Save (musicDisabled, "musicDisabled");
	
		//mController.MusicDisable ();

	}
}
