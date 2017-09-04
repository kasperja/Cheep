using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundNear : MonoBehaviour {
	public SpawnScript spawnGroundScript;
   // public bool spawnReady = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {

        spawnGroundScript.isEmpty = true;

    }


	void OnTriggerEnter2D(Collider2D other){

       
        //Debug.Log ("HI2");
        if (other.tag == "Ground") {
            spawnGroundScript.counter++;
            spawnGroundScript.spawnBoundsR = false;
            //  spawnReady = false;
            spawnGroundScript.hasExited = false;
            spawnGroundScript.hasExitedOnce = false;

        }








	}

	void OnTriggerStay2D(Collider2D other){

        spawnGroundScript.isEmpty = false;

        if (other.tag == "Ground") {

            spawnGroundScript.spawnBoundsR = false;
            //spawnGroundScript.hasExited = false;
            //spawnGroundScript.hasExitedOnce = false;
            //spawnReady = false;

        }
    //Debug.Log ("HI3");

    //spawnGroundScript.spawnBoundsR = false;









}
	void OnTriggerExit2D(Collider2D other){
        //Debug.Log ("HI4");

        
        if (other.tag == "Ground") {
            spawnGroundScript.counter--;
            spawnGroundScript.spawnBoundsR = true;
            //spawnGroundScript.StartCoroutine("waitToBeSureTwo");
            spawnGroundScript.hasExited = true;
            spawnGroundScript.hasExitedOnce = true;
   // spawnReady = true;

}








	}

}
