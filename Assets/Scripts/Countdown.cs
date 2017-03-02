using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public TextMesh textM;
	public AudioSource countdownSound;
	public AudioSource beginSound;
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
		yield return new WaitForSeconds (1f);
		countdownSound.Play ();
		textM.text = "2";
		yield return new WaitForSeconds (1f);
		countdownSound.Play ();
		textM.text = "1";
		yield return new WaitForSeconds (1f);
		beginSound.Play ();
		textM.text = "GO!";
		yield return new WaitForSeconds (1f);
		textM.text = " ";

	
	}
}
