using UnityEngine;
using System.Collections;

public class PowerupColScript : MonoBehaviour {

	public AudioSource powerupSound;
	public AudioSource powerupSound2;
	public AudioSource powerupSound3;
	public AudioSource powerupSound4;
	public AudioSource powerupSoundSuper;
	public AudioSource powerupSoundSuper2;
	public AudioSource powerupSoundSuper3;
	public AudioSource powerupSoundSuper4;
	public ParticleSystem pwrupParticle;
	public GameObject scoreTxt;
	public float randomFloat = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		randomFloat = Random.Range (0f, 4f);
	
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.tag == "Powerup") {
		
			//iTween.PunchScale (scoreTxt, new Vector3 (3f, 0.2f, 0f), 0.5f);
			if(randomFloat < 1f){

				powerupSound.Play ();

			}else if(randomFloat >= 1f && randomFloat < 2f){

				powerupSound2.Play ();

			}else if(randomFloat >= 2f && randomFloat < 3f){
				
				powerupSound3.Play ();


			}else if(randomFloat >=3f){
				powerupSound4.Play ();

			}

			//powerupSound.Play ();
			pwrupParticle.Play ();
		}

		if (col.tag == "PowerupSuper") {

			//iTween.PunchScale (scoreTxt, new Vector3 (3f, 0.2f, 0f), 0.5f);
			if(randomFloat < 1f){

				powerupSoundSuper.Play ();

			}else if(randomFloat >= 1f && randomFloat < 2f){

				powerupSoundSuper2.Play ();

			}else if(randomFloat >= 2f && randomFloat < 3f){

				powerupSoundSuper3.Play ();


			}else if(randomFloat >=3f){
				powerupSoundSuper4.Play ();

			}

			//powerupSound.Play ();
			pwrupParticle.Play ();
		}
	
	}
}
