using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	public Image image;
	public bool isStarted = false;
	public bool isEnded = false;
	public Color col1;
	public Color col2;
	private float t = 0f;
	private float t2 = 0f;
	public AudioSource music;

	public bool isStartScreen = false;
	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		if (isStarted) {

			isEnded = false;

			if(isStartScreen)music.volume -= 2f * Time.deltaTime;

			t += 2f * Time.deltaTime;

			image.color = Color.Lerp(col1, col2, t);
		
		}
		if (isEnded) {
			
			if(!isStartScreen)music.volume -= 2f * Time.deltaTime;

			t2 += 2f * Time.deltaTime;

			image.color = Color.Lerp(col2, col1, t2);
		
		}

	}
}
