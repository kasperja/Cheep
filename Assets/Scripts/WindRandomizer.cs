using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindRandomizer : MonoBehaviour {

    public AudioSource windTopAmbience;
    private float maxVol;

    private bool decreaseVol = false;
    private bool increaseVol = false;

    private float randomTime = 5f;
	// Use this for initialization
	void Start () {
        maxVol = windTopAmbience.volume;


        StartCoroutine(windRandom());
	}
	
	// Update is called once per frame
	void Update () {

        randomTime = Random.Range(5f, 15f);

        if (decreaseVol && windTopAmbience.volume > 0f)
        {

            windTopAmbience.volume -= 0.2f * Time.deltaTime;

        }
        else if (increaseVol && windTopAmbience.volume < maxVol) {

            windTopAmbience.volume += 0.2f * Time.deltaTime;

        }

	}

    IEnumerator windRandom() {
        
        yield return new WaitForSeconds(randomTime);
        decreaseVol = true;
        increaseVol = false;
        yield return new WaitForSeconds(randomTime);
        increaseVol = true;
        decreaseVol = false;

        StartCoroutine(windRandom());

    }
}
