using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeOut : MonoBehaviour {

	public Text txt;
	private bool playOnce = true;
	private Color color;
	public float fadeSpeed = 0.1f;
	public float fadeAmmount = 1f;
	public Color col1;
	public Color col2;
	float t = 0f;

	public bool playOncePlus = true;

	public bool txtFadeActivate = false;
	// Use this for initialization
	void Start () {

		txt.color = col2;

	}

	// Update is called once per frame
	void Update () {

		if (t >= 1f) {

			txtFadeActivate = false;
		
		}

		if (txtFadeActivate) {
			if (playOnce) {
				txt.color = col1;

				playOnce = false;
			}
			txt.color = Color.Lerp (col1, col2, t);
			if (t <= 1f) {
				t += Time.deltaTime * 2f;
			}
			

		} else {
		
			t = 0f;
			//txt.color = col2;
		
		}

		if (txt.color == col2) {
			
			t = 0f;
		
		}


		/*if (playOnce) {

			StartCoroutine (Fader (1f));



		
		}*/


	}
	/*IEnumerator Fader(float time){
		
		playOnce = false;

		if (txt.color.a >= 1f) {
			color = Color.Lerp(0, 0, 0, 0.6f);

			yield return new WaitForSeconds (time / 60f);
		} else if (txt.color.a <= 0.6f) {
			color = new Color (0, 0, 0, Mathf.Lerp (0.6f, 1f, Time.time));

			yield return new WaitForSeconds (time / 60f);
		}
		playOnce = true;

	}*/
}