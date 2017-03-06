using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public ParticleSystem deathParticle;
	public GameObject particlesObj;
	public PlatformerCharacter2D pc2d;
	public AudioSource scream1;
	public AudioSource scream2;
	public AudioSource scream3;
	public AudioSource music;
	private bool fadeMusic = false;

	public bool dieBool = false;
	private bool dieOnce = true;

	public GameObject graphicsPlayer;

	void Update(){
	
		if (fadeMusic) {

			music.volume -= 0.4f * Time.deltaTime;

		}


		if (dieBool && dieOnce) {
		
			pc2d.isDead = true;
			pc2d.m_MaxSpeed = 0f;
			deathParticle.Play ();
			StartCoroutine (waitForDeath ());
			graphicsPlayer.SetActive (false);
			dieOnce = false;
			//Application.LoadLevel (2);
		
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
		particlesObj.SetActive (false);
		fadeMusic = true;
		if (pc2d.scream1)scream1.Play ();

		if(pc2d.scream2)scream2.Play ();

		if(pc2d.scream3)scream3.Play ();


		yield return new WaitForSeconds (1f);
		Application.LoadLevel (2);
		//return;

	}
}
