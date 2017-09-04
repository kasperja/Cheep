using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundNearUniversal : MonoBehaviour
{
    //public SpawnScript spawnGroundScript;
    public bool spawnReady = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {


        //Debug.Log ("HI2");
        if (other.tag == "Ground")
        {

           // spawnGroundScript.spawnBoundsR = false;
            spawnReady = false;

        }








    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "Ground")
        {

           // spawnGroundScript.spawnBoundsR = false;
            spawnReady = false;

        }
        //Debug.Log ("HI3");

        //spawnGroundScript.spawnBoundsR = false;









    }
    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log ("HI4");


        if (other.tag == "Ground")
        {
            //spawnGroundScript.spawnBoundsR = true;
            spawnReady = true;

        }








    }

}
