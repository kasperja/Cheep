using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterApply : MonoBehaviour {
	private int currentChara = 0;

	public Animator m_Anim;
	public GameObject graphics;
	public GameObject graphicsLizard;
	public GameObject graphicsAlien;
	public GameObject graphicsCat;
	public GameObject graphicsHippo;
	// Use this for initialization
	void Start () {
		
		if (ES2.Exists ("currentChar")) {

			currentChara = ES2.Load<int> ("currentChar");

		}

		if (currentChara == 0) {
		
			graphics.SetActive (true);
			graphicsLizard.SetActive (false);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (false);
			graphicsHippo.SetActive (false);
		
		} else if (currentChara == 1) {
		
			graphics.SetActive (false);
			graphicsLizard.SetActive (true);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (false);
			graphicsHippo.SetActive (false);
			m_Anim.SetBool ("isLizard", true);
		
		
		}else if (currentChara == 2) {

			graphics.SetActive (false);
			graphicsLizard.SetActive (false);
			graphicsAlien.SetActive (true);
			graphicsCat.SetActive (false);
			graphicsHippo.SetActive (false);
			m_Anim.SetBool ("isAlien", true);


		}else if (currentChara == 3) {

			graphics.SetActive (false);
			graphicsLizard.SetActive (false);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (true);
			graphicsHippo.SetActive (false);
			m_Anim.SetBool ("isCat", true);


		}else if (currentChara == 4) {

			graphics.SetActive (false);
			graphicsLizard.SetActive (false);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (false);
			graphicsHippo.SetActive (true);
			m_Anim.SetBool ("isHippo", true);


		}

		
	}
	
	// Update is called once per frame
	void Update () {



	}
}
