using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundNear : MonoBehaviour {
	public SpawnScript spawnGroundScript;
    public bool isMax = false;
    public bool isMaxObj = false;
   // public bool spawnReady = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isMaxObj && spawnGroundScript.counter == 0) spawnGroundScript.isMaxSpawn = true;
		
	}
    void FixedUpdate()
    {

      if(!isMaxObj)  spawnGroundScript.isEmpty = true;

    }


	void OnTriggerEnter2D(Collider2D other){

       
        //Debug.Log ("HI2");
        if (other.tag == "Ground") {

            if (isMaxObj)
            {
                spawnGroundScript.maxCounter++;


            }
            if (!isMaxObj) {
                spawnGroundScript.counter++;
                spawnGroundScript.spawnBoundsR = false;
                //  spawnReady = false;
                spawnGroundScript.hasExited = false;
                spawnGroundScript.hasExitedOnce = false;



            }

        }








	}

	void OnTriggerStay2D(Collider2D other){

       //if(!isMaxObj) spawnGroundScript.isEmpty = false;

        if (other.tag == "Ground") {

            if (!isMaxObj)
            {
                spawnGroundScript.spawnBoundsR = false;
            }
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

            if (isMaxObj) {
                spawnGroundScript.maxCounter--;
                

            }

            if (!isMaxObj)
            {
                spawnGroundScript.counter--;
                spawnGroundScript.spawnBoundsR = true;
                //spawnGroundScript.StartCoroutine("waitToBeSureTwo");
                spawnGroundScript.hasExited = true;
                spawnGroundScript.hasExitedOnce = true;
            }
   // spawnReady = true;

}








	}

}
