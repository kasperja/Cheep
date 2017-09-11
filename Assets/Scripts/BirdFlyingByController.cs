using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlyingByController : MonoBehaviour {

    public Animator birdFlyingByAnimator;
    public Transform birdTransform;

    public Renderer rendererBird;
    private bool isFirstStart = true;
    public bool isMirrored = false;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitAndRestart());
        //origTransform = transform;
        birdFlyingByAnimator.StopPlayback();
        birdTransform = transform;
        birdTransform.position += new Vector3(0f, Random.Range(-10f, 7f),0f);
        birdFlyingByAnimator.SetBool("StartOver", false);
    }
	
	// Update is called once per frame
	void Update () {

        
		
	}
    IEnumerator waitAndRestart() {
        if (isFirstStart)
        {
            yield return new WaitForSeconds(Random.Range(0f, 20f));
            isFirstStart = false;
        }
        else {

            yield return new WaitForSeconds(Random.Range(10f, 50f));
        }


        if (!rendererBird.isVisible)
        {
            birdFlyingByAnimator.SetBool("StartOver", true);
            birdTransform.position = transform.position;
            if (!isMirrored) {

                birdTransform.position += new Vector3(0f, Random.Range(-10f, 7f), 0f);

            } else {

                birdTransform.position += new Vector3(0f, Random.Range(-10f, 7f), 0f);

            }
        }
        yield return new WaitForSeconds(1f);
        birdFlyingByAnimator.SetBool("StartOver", false);
        StartCoroutine(waitAndRestart());
    }
}
