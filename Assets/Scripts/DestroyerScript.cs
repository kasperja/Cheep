using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	public ParticleSystem deathParticle;
	public GameObject particlesObj;
	public PlatformerCharacter2D pc2d;
	public AudioSource scream1;
	public AudioSource scream2;
	public AudioSource scream3;
	//public AudioSource music;
	private bool fadeMusic = false;

	public bool dieBool = false;
	private bool dieOnce = true;


	public GameObject graphicsPlayer;
	public GameObject graphicsLizard;
	public GameObject graphicsAlien;
	public GameObject graphicsCat;
	public GameObject graphicsHippo;

	//public ObjectPoolManager objm;

	void Update(){
		
		if(scream1.time >= 1.1f)scream1.volume = 0f;
		/*if (fadeMusic) {

			music.volume -= 0.4f * Time.deltaTime;

		}*/


		if (dieBool && dieOnce) {
			Time.timeScale = 1f;
			pc2d.isDead = true;
			pc2d.m_MaxSpeed = 0f;
			deathParticle.Play ();
			StartCoroutine (waitForDeath ());
			graphicsPlayer.SetActive (false);
			graphicsLizard.SetActive (false);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (false);
			graphicsHippo.SetActive (false);

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

			//objm.Release (other.gameObject.transform.parent.gameObject);
			Destroy (other.gameObject.transform.parent.gameObject);

		} else {

			//objm.Release (other.gameObject);
			Destroy (other.gameObject);
		
		}


	}

	IEnumerator waitForDeath(){
		particlesObj.SetActive (false);
		fadeMusic = true;
		scream1.Play ();





		yield return new WaitForSeconds (3f);
		Application.LoadLevel (2);
		//return;

	}
}
