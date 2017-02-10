﻿using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public ParticleSystem deathParticle;
	public PlatformerCharacter2D pc2d;
	public AudioSource scream1;
	public AudioSource scream2;
	public AudioSource scream3;
	public AudioSource music;
	private bool fadeMusic = false;

	void Update(){
	
		if (fadeMusic) {

			music.volume -= 0.4f * Time.deltaTime;

		}

	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			pc2d.isDead = true;
			pc2d.m_MaxSpeed = 0f;
			deathParticle.Play ();
			StartCoroutine (waitForDeath ());
			//Application.LoadLevel (2);
			return;
		
		}

		if (other.gameObject.transform.parent) {

			Destroy (other.gameObject.transform.parent.gameObject);

		} else {

			Destroy (other.gameObject);
		
		}


	}

	IEnumerator waitForDeath(){
		fadeMusic = true;
		if (pc2d.scream1)scream1.Play ();

		if(pc2d.scream2)scream2.Play ();

		if(pc2d.scream3)scream3.Play ();


		yield return new WaitForSeconds (3.5f);
		Application.LoadLevel (2);
		//return;

	}
}
