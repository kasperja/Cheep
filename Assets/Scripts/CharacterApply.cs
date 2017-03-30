using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterApply : MonoBehaviour {
	private int currentChara = 0;

	public Animator m_Anim;
	public GameObject graphics;
	public GameObject graphicsLizard;
	// Use this for initialization
	void Start () {
		
		if (ES2.Exists ("currentChar")) {

			currentChara = ES2.Load<int> ("currentChar");

		}

		if (currentChara == 0) {
		
			graphics.SetActive (true);
			graphicsLizard.SetActive (false);
		
		} else if (currentChara == 1) {
		
			graphics.SetActive (false);
			graphicsLizard.SetActive (true);
			m_Anim.SetBool ("isLizard", true);
		
		
		}

		
	}
	
	// Update is called once per frame
	void Update () {



	}
}
