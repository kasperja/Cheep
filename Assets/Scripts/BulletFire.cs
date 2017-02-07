using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

    public GameObject bulletPrefab;
    public Rigidbody crb;
    public ParticleSystem particleHit;
    public GameObject Clone;
    public bool CanShoot = true;
    
    //public float timestamp = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && CanShoot == true)
        {//when the left mouse button is clicked

            //print("1");//print a message to act as a debug

            FireBullet();
            this.gameObject.GetComponent<AudioSource>().Play();
            CanShoot = false;
            StartCoroutine(Reload());
          //  timestamp = Time.time + timestamp;

        }



	}

    public void FireBullet() {

        Clone = (Instantiate(bulletPrefab, (transform.position + transform.up), transform.rotation)) as GameObject;

        
  
    }
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            //iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
            
            
          //  particleHit.Play();

        }


    }

     
    IEnumerator Reload(){
        
        yield return new WaitForSeconds(0.05f);
        CanShoot = true;
        
 }

}
