using UnityEngine;
using System.Collections;

public class Bounce1 : MonoBehaviour {

    public ParticleSystem particleHit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            //iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
            this.gameObject.GetComponent<AudioSource>().Play();
            particleHit.Play();
        }


    }
}
