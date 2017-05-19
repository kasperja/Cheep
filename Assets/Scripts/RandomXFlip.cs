using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomXFlip : MonoBehaviour {

	// Use this for initialization
	void Start () {

		float random = Random.Range (0,1);
		if (random <= 0.5f) {
			GetComponent<SpriteRenderer> ().flipX = true;
		} else {
		
		
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
