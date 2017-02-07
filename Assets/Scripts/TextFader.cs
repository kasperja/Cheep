using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFader : MonoBehaviour {

	public Text txt;
	private bool playOnce = true;
	private Color color;
	public float fadeSpeed = 0.7f;
	public float fadeAmmount = 0.4f;
	public Color col1;
	public Color col2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		txt.color = Color.Lerp (col1, col2, Mathf.PingPong(Time.time, fadeSpeed));


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
