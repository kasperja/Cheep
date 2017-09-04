using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MasterMixerScript : MonoBehaviour {

    public static bool bypassEffects = true;
    //public AudioMixerGroup master;
    public AudioSource[] allAudio;
	// Use this for initialization
	void Start () {
      //  masterNoEcho.TransitionTo(0.1f);
       allAudio = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

    }
	
	// Update is called once per frame

	void Update () {

        

        if (Input.GetKey(KeyCode.A))
        {
            bypassEffects = false;
            foreach (AudioSource audio in allAudio) {
                audio.bypassEffects = false;


            }

        }
        else {

            bypassEffects = true;
            foreach (AudioSource audio in allAudio)
            {
                audio.bypassEffects = true;


            }

        }
        //masterNoEcho.TransitionTo(0.1f);
        // masterEcho.TransitionTo(0.1f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {


        //Debug.Log ("HI2");
        
    }

    }
