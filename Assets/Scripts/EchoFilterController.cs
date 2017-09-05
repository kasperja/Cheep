using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoFilterController : MonoBehaviour {

    public AudioEchoFilter echoFilter;
    // Use this for initialization
    
    public int counter = 0;
	void Start () {
      //  echoFilter.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (counter > 0 || Input.GetKey(KeyCode.A)) {
        //   echoFilter.enabled = true;
           if(echoFilter.wetMix < 0.5f) echoFilter.wetMix += 1f * Time.deltaTime;

        }else
        {

//            echoFilter.enabled = false;
            if(echoFilter.wetMix > 0f)echoFilter.wetMix -= 1f * Time.deltaTime;

        }
        */
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        counter++;


        Debug.Log("ECHO!");








    }
    void OnTriggerExit2D(Collider2D other)
    {
        counter--;
        










    }
}
