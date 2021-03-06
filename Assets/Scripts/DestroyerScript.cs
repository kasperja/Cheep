﻿using UnityEngine;
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
	public GameObject graphicsAlien;
	public GameObject graphicsCat;
    public GameObject graphicsPanda;
    public GameObject graphicsLizard;
    public GameObject graphicsTaco;
    public GameObject graphicsHippo;
    public GameObject graphicsRobby;
    public GameObject graphicsBugo;
    public GameObject graphicsHrumpf;
    

    private bool fadeEnabled = true;
    //public ObjectPoolManager objm;

    void Update(){
		
		if(scream1.time >= scream1.clip.length)scream1.volume = 0f;
        /*if (fadeMusic) {

			music.volume -= 0.4f * Time.deltaTime;

		}*/

        if (Input.GetKeyDown(KeyCode.U)) {

            EZCameraShake.CameraShaker.Instance.ShakeOnce(pc2d.shakeMagnitude, pc2d.shakeRoughness, pc2d.shakeFadeIn, pc2d.shakeFadeOut);

        }

		if (dieBool && dieOnce) {
            ES2.Save(fadeEnabled, "fadeEnabled");
            EZCameraShake.CameraShaker.Instance.ShakeOnce(pc2d.shakeMagnitude, pc2d.shakeRoughness, pc2d.shakeFadeIn, pc2d.shakeFadeOut);
            Time.timeScale = 1f;
			pc2d.isDead = true;
			pc2d.m_MaxSpeed = 0f;
			deathParticle.Play ();
			StartCoroutine (waitForDeath ());
			graphicsPlayer.SetActive (false);
			graphicsAlien.SetActive (false);
			graphicsCat.SetActive (false);
			graphicsPanda.SetActive (false);
			graphicsLizard.SetActive (false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
           

            dieOnce = false;
			//Application.LoadLevel (2);
		
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			pc2d.isDead = true;
			pc2d.m_MaxSpeed = 0f;
			deathParticle.Play ();
            //StartCoroutine (waitForDeath ());
            dieBool = true;
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

        yield return new WaitForSeconds(1.2f);

        pc2d.fadeOutScript.isEnded = true;
        AudioListener.volume -= 10f * Time.deltaTime;
        yield return new WaitForSeconds (0.8f);
		Application.LoadLevel (2);
		//return;

	}
}
