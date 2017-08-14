using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoosterScript : MonoBehaviour {

	private PlatformerCharacter2D pc2D;
	private AudioSource speedBoostSound;
    private AudioSource speedBoostSoundTwo;
    private AudioSource speedBoostSoundThree;
    private bool soundOnce = true;

	private bool boostActivate = false;
	private bool boostDeactivate = false;

	private float speedBoostAmmount = 20f;

	public ParticleSystem boostParticle;



	private ParticleSystem boostTextPart;
    private float randomFloat;



	void Start () {


		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();
		boostTextPart = GameObject.Find ("BoostTextPart").GetComponent<ParticleSystem> ();
		speedBoostSound = GameObject.Find ("SpeedBoostSound").GetComponent<AudioSource> ();
        speedBoostSoundTwo = GameObject.Find("SpeedBoostSound2").GetComponent<AudioSource>();
        speedBoostSoundThree = GameObject.Find("SpeedBoostSound3").GetComponent<AudioSource>();



    }
	// Update is called once per frame
	void Update () {

        randomFloat = Random.Range(0f, 3f);


		if (boostActivate) {



			pc2D.boostActivate = true;
			if (!pc2D.isDead) {

				if (soundOnce) {

                    if (randomFloat < 1f)
                    {

                        speedBoostSound.Play();

                    }
                    else if (randomFloat >= 1f && randomFloat < 2f)
                    {

                        speedBoostSoundTwo.Play();
                    }
                    else
                    {

                        speedBoostSoundThree.Play();

                    }

                    
					soundOnce = false;
				}
				if (pc2D.m_MaxSpeed < pc2D.boostOrig * 3f && !pc2D.isDead)
				if (pc2D.m_MaxSpeed < 25f)
					pc2D.m_MaxSpeed += speedBoostAmmount * Time.deltaTime;
			}
		
		} else if (boostDeactivate) {
		
			soundOnce = true;


			if (!pc2D.isDead) {
				if (pc2D.m_MaxSpeed > 17f)
					pc2D.m_MaxSpeed -= speedBoostAmmount * Time.deltaTime;
			}
			if (pc2D.m_MaxSpeed <= 17f) {
			
				boostDeactivate = false;
				pc2D.boostActivate = false;
			
			}
		} 

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {





			boostParticle.Play ();
			boostTextPart.Play ();

			StartCoroutine (boostNum ());

			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();

			//  particleHit.Play();


		}

	}

	IEnumerator boostNum(){
		
		boostActivate = true;
		yield return new WaitForSeconds (1f);
		boostActivate = false;
		boostDeactivate = true;

	}
}
