using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoosterScript : MonoBehaviour {

	private PlatformerCharacter2D pc2D;

	private bool boostActivate = false;
	private bool boostDeactivate = false;

	public float speedBoostAmmount = 20f;

	public ParticleSystem boostParticle;



	private ParticleSystem boostTextPart;



	void Start () {


		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();

		boostTextPart = GameObject.Find ("BoostTextPart").GetComponent<ParticleSystem> ();

	}
	// Update is called once per frame
	void Update () {




		if (boostActivate) {

			pc2D.boostActivate = true;
			if (!pc2D.isDead) {
				
				if (pc2D.m_MaxSpeed < pc2D.boostOrig * 2f && !pc2D.isDead)
				if (pc2D.m_MaxSpeed < 20f)
					pc2D.m_MaxSpeed += speedBoostAmmount * Time.deltaTime;
			}
		
		} else if (boostDeactivate) {
		
			if (!pc2D.isDead) {
				if (pc2D.m_MaxSpeed > 14f)
					pc2D.m_MaxSpeed -= speedBoostAmmount * Time.deltaTime;
			}
			if (pc2D.m_MaxSpeed <= 15f) {
			
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
