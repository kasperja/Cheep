using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public TextMesh textM;
	public AudioSource countdownSound;
	public AudioSource beginSound;
	public Animator countdownAnimator;
	// Use this for initialization
	void Start () {

		StartCoroutine (countdownNum ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator countdownNum(){
	
		countdownSound.Play ();
		textM.text = "3";
		countdownAnimator.SetInteger ("countdown", 3);
		yield return new WaitForSeconds (1f);
		countdownSound.Play ();
		textM.text = "2";
		countdownAnimator.SetInteger ("countdown", 2);
		yield return new WaitForSeconds (1f);
		countdownSound.Play ();
		textM.text = "1";
		countdownAnimator.SetInteger ("countdown", 1);
		yield return new WaitForSeconds (1f);
		beginSound.Play ();
		textM.text = "GO!";
		countdownAnimator.SetInteger ("countdown", 0);
		yield return new WaitForSeconds (1f);
		textM.text = " ";

	
	}
}
