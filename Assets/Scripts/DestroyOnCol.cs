using UnityEngine;
using System.Collections;

public class DestroyOnCol : MonoBehaviour {

    public float BulletSpeed = 20f;
	// Use this for initialization
	void Start () {

        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * BulletSpeed);
        

	}
	
	// Update is called once per frame
	void Update () {

        
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            //iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
            //this.gameObject.GetComponent<AudioSource>().Play();

            //  particleHit.Play();
            Destroy(gameObject);

        }
        else {
            Destroy(gameObject);

        }


    }

}
