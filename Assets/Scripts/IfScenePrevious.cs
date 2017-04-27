using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfScenePrevious : MonoBehaviour {

	public AudioSource buttonSound;

	private int prevScene = 0;
	// Use this for initialization
	void Start () {

		if (ES2.Exists ("prevScene")) {

			prevScene = ES2.Load<int> ("prevScene");

		}

		if (prevScene == 0 || prevScene == 2)buttonSound.Play ();

		prevScene = 2;

		ES2.Save (prevScene, "prevScene");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
