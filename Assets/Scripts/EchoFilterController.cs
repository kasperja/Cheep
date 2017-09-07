using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoFilterController : MonoBehaviour {

   // public AudioEchoFilter echoFilter;
    public AudioReverbFilter reverbFilter;
    // Use this for initialization
    
    public int counter = 0;
    public int counterMonk = 0;

    private bool monkOnce = true;

    public AudioSource monkVoice;
    public AudioSource monkBell;

    private bool monkReady = true;
    void Start () {
      //  echoFilter.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (counter > 0 || Input.GetKey(KeyCode.A)) {
            //   echoFilter.enabled = true;
            //if(echoFilter.wetMix < 0.5f) echoFilter.wetMix += 1f * Time.deltaTime;
            if (reverbFilter.reverbLevel < 0) reverbFilter.reverbLevel += 10000f * Time.deltaTime;

        }
        else
        {

            //            echoFilter.enabled = false;
            //if(echoFilter.wetMix > 0f)echoFilter.wetMix -= 1f * Time.deltaTime;
            if (reverbFilter.reverbLevel > -10000f) reverbFilter.reverbLevel -= 4000f * Time.deltaTime;

        }
        if ((counterMonk > 0) && monkOnce && monkReady)
        {
            //   echoFilter.enabled = true;
           // Debug.Log("monk!!!");
            monkVoice.Play();
            StartCoroutine(monkBellWait());
            //if(echoFilter.wetMix < 0.5f) echoFilter.wetMix += 1f * Time.deltaTime;
            //if (reverbFilter.reverbLevel < 0) reverbFilter.reverbLevel += 10000f * Time.deltaTime;
            monkOnce = false;
            monkReady = false;

        }
        else if(counterMonk == 0)
        {
            monkOnce = true;
            //            echoFilter.enabled = false;
            //if(echoFilter.wetMix > 0f)echoFilter.wetMix -= 1f * Time.deltaTime;
           // if (reverbFilter.reverbLevel > -10000f) reverbFilter.reverbLevel -= 4000f * Time.deltaTime;

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "EchoCamera")
        { counter++; }


        if (other.tag == "Monk")
        { counterMonk++; }


        //  Debug.Log("ECHO!");








    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "EchoCamera")
        { counter--; }

        if (other.tag == "Monk")
        { counterMonk--; }











    }

    IEnumerator monkBellWait() {

        yield return new WaitForSeconds(2f);
        monkBell.Play();
        yield return new WaitForSeconds(10f);
        monkReady = true;
       // Debug.Log(monkReady);

    }
}
