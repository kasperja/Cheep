using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupRocket : MonoBehaviour {

	private PlatformerCharacter2D pc2D;
	private Countdown countdown;

	void Start(){
	
		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();
		countdown = GameObject.Find ("Countdown").GetComponent<Countdown> ();
	
	}

	void Update () {
	
	
	
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			
			pc2D.isRocket = true;
			countdown.isRocket = true;

			StartCoroutine (waitRocket ());

			GetComponent<SpriteRenderer> ().enabled = false;

		}
	}
	IEnumerator waitRocket(){
	
		yield return new WaitForSeconds (5f);

		Destroy (this.gameObject);
	}
}
