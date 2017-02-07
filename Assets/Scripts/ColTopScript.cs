using UnityEngine;
using System.Collections;

public class ColTopScript : MonoBehaviour {

	public ParticleSystem hitTopParticle;
	public AudioSource hitTopSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){

		hitTopSound.Play ();
		hitTopParticle.Play ();


	}
}
