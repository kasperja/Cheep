using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundNear : MonoBehaviour {
	public SpawnScript spawnGroundScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other){


		//Debug.Log ("HI2");
		spawnGroundScript.spawnBoundsR = false;








	}

	void OnTriggerStay2D(Collider2D other){


		//Debug.Log ("HI3");

			//spawnGroundScript.spawnBoundsR = false;









	}
	void OnTriggerExit2D(Collider2D other){
		//Debug.Log ("HI4");


		spawnGroundScript.spawnBoundsR = true;








	}

}
