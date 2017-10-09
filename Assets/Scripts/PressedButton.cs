using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedButton : MonoBehaviour {
	private Animator animatorButton;
	private AudioSource buttonSound;
	public bool hasSound = true;
    public bool hasAnim = true;
	// Use this for initialization
	void Start () {
		animatorButton = GetComponent<Animator> ();
		buttonSound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayAnim(){
        //buttonSound = GetComponent<AudioSource>();
       if(hasAnim) animatorButton.SetBool ("Pressed", true);
		if(hasSound)buttonSound.Play ();
		StartCoroutine (waitFalse ());
	
	}

	IEnumerator waitFalse() {

		yield return new WaitForSeconds (0f);
		if(hasAnim)animatorButton.SetBool ("Pressed", false);
	
	}
}
