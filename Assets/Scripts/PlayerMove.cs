using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public Rigidbody rb;
    public Vector3 rota;
    public float RotateSpeed = 500f;
    public float ThrustSpeed = 100f;
    public ParticleSystem pe;
    public ParticleSystem pf;
    public ParticleSystem pftwo;
    public AudioSource ThrustSound;
    public Camera Mcam;
    public float speed = 1f;
    //public GameObject playerOne;


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
      
	}
	
	// Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.LeftArrow))

            transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);

        else if (Input.GetKey(KeyCode.RightArrow))

            transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);

        /*Vector3 position = Mcam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mcam.nearClipPlane));
        

        transform.LookAt(new Vector3(position.x, position.y, transform.position.z), Vector3.forward);*/

        /*var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        var hitdist = 10.0f;

        var targetPoint = ray.GetPoint(hitdist);

        var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);*/


        if (Input.GetKey(KeyCode.UpArrow))
        {
            pe.Play();
            
            if (!ThrustSound.isPlaying) {
                ThrustSound.loop = true;
               // ThrustSound.Play(); 
            }
            
            rb.AddForce(transform.up * ThrustSpeed);

        }
        else { pe.Stop(); ThrustSound.Stop(); }

        if (Input.GetKey(KeyCode.Space))
        {

            pftwo.Play();
            pf.Play();

        }
        else { pf.Stop(); pftwo.Stop(); }

        
    
    }

	void FixedUpdate () {

       
	
	}
}
