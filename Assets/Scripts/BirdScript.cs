using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    private Animator birdAnimator;
    public bool isFlying2 = false;
    public bool isFlying3 = false;
    public bool isFlying4 = false;
    public bool isFlying5 = false;
    public AudioSource birdSound;
    public AudioSource birdSound2;
    private float randomFloat = 0;
    // Use this for initialization
    void Start () {
        
       birdAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        randomFloat = Random.Range(0f,2f);
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            if (isFlying2) {

                if (randomFloat < 1f)
                {

                    birdSound.Play();

                }
                else
                {

                    birdSound2.Play();
                }
                birdAnimator.SetBool("isFlying2", true);

            } else if (isFlying3) {

                birdAnimator.SetBool("isFlying3", true);
            }
            else if (isFlying4)
            {
                if (randomFloat < 1f)
                {

                    birdSound.Play();

                }
                else
                {

                    birdSound2.Play();
                }
                birdAnimator.SetBool("isFlying4", true);

            }
            else if (isFlying5)
            {
                birdAnimator.SetBool("isFlying5", true);

            }
            else
            {
                if (randomFloat < 1f) {

                    birdSound.Play();

                } else {

                    birdSound2.Play();
                }

                birdAnimator.SetBool("isFlying", true);
            }
            

        }


     


        //  Debug.Log("ECHO!");








    }
}
