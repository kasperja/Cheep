using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

	public TextMesh textM;
	public AudioSource countdownSound;
	public AudioSource beginSound;
	public Animator countdownAnimator;
	public HUDScript hud;
	public bool isRocket = false;
	private bool isRocketOnce = true;
	// Use this for initialization
	void Start () {

		StartCoroutine (countdownNum ());
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isRocket && isRocketOnce) {
			
			StartCoroutine (countdownNumRocket ());

			isRocketOnce = false;
		
		}
		
	}

	IEnumerator countdownNum(){
	
		countdownSound.Play ();
		textM.text = "3";
		countdownAnimator.SetInteger ("countdown", 3);
		yield return new WaitForSeconds (1f);
        textM.text = " ";
        countdownSound.Play ();
		textM.text = "2";
		countdownAnimator.SetInteger ("countdown", 2);
		yield return new WaitForSeconds (1f);
        textM.text = " ";
        countdownSound.Play ();
		textM.text = "1";
		countdownAnimator.SetInteger ("countdown", 1);
		if (!isRocket) {
			yield return new WaitForSeconds (1f);
            textM.text = " ";
            beginSound.Play ();
			textM.text = "GO!";
		}
		hud.goDone = true;
		countdownAnimator.SetInteger ("countdown", 0);
        
        if (!isRocket)yield return new WaitForSeconds (1f);
		textM.text = " ";
        countdownAnimator.SetInteger("countdown", -1);
        isRocket = false;
		isRocketOnce = true;

	
	}
	IEnumerator countdownNumRocket(){
		
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
		//if (!isRocket) {
			yield return new WaitForSeconds (1f);
			beginSound.Play ();
			textM.text = "GO!";
		//}
		hud.goDone = true;
		countdownAnimator.SetInteger ("countdown", 0);
		yield return new WaitForSeconds (2f);
		textM.text = " ";
		isRocket = false;
		isRocketOnce = true;



	}
}
