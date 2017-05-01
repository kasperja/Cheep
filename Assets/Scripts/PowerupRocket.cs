using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupRocket : MonoBehaviour {

	private PlatformerCharacter2D pc2D;


	void Start(){
	
		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();
	
	}

	void Update () {
	
	
	
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {


			pc2D.isRocket = true;
			Destroy (this.gameObject);

		}
	}
}
