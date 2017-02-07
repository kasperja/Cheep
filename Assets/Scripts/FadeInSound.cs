using UnityEngine;
using System.Collections;

public class FadeInSound : MonoBehaviour {

	public AudioSource hit;
	public AudioSource hit2;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if(hit.volume < 1f) hit.volume += 0.5f * Time.deltaTime;
		if(hit2.volume < 1f) hit2.volume += 0.5f * Time.deltaTime;
	
	}
}
