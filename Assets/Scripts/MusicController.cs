/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour {

	private bool musicDisabled = false;
	private float startVol = 0f;
	public AudioSource music;

	void Awake(){
	

	
	}
	// Use this for initialization
	void Start () {



		music = gameObject.GetComponent<AudioSource>();

		startVol = music.volume;

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		if (musicDisabled) {
		
			music.volume = 0f;

		
		} else {
		
			music.volume = startVol;

		
		}
		
	}

	public void MusicDisable () {

		music = gameObject.GetComponent<AudioSource> ();

		if (ES2.Exists ("musicDisabled")) {

			musicDisabled = ES2.Load<bool> ("musicDisabled");

		}

		if (musicDisabled) {

			music.volume = 0f;;

		} else {

			music.volume = startVol;

		}
		//ES2.Save (musicDisabled, "musicDisabled");

	}

	// Update is called once per frame
	void Update () {


		
		
		
	}
}*/
