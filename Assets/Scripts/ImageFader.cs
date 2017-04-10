using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFader : MonoBehaviour {

	// Use this for initialization
	public Image img;
	private bool playOnce = true;
	private Color color;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {


		img.color = Color.Lerp (new Color(img.color.r,img.color.g,img.color.b,0.6f), new Color(img.color.r,img.color.g,img.color.b,1f), Mathf.PingPong(Time.time, 0.7f));


		/*if (playOnce) {

			StartCoroutine (Fader (1f));



		
		}*/


	}
}
