using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRotation : MonoBehaviour {

	//public RotateCam camRotateScript;
	private Transform target;
	//public float speed = 10f;
	//public RotateCam rCam;
	public bool isFG = false;
    public bool isTemple = false;
	// Use this for initialization
	void Start () {

		target = GameObject.Find ("Main Camera").GetComponent<Transform>();
		if (!isFG) {
			transform.rotation = Quaternion.Euler(0f, 0f, target.rotation.eulerAngles.z);
        } else {

			transform.rotation = Quaternion.Euler(0f, 0f, target.rotation.eulerAngles.z);

        }
		//rCam = target.GetComponent<RotateCam> ();
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

		if (!isFG) {
            transform.rotation = Quaternion.Euler(0f, 0f, target.rotation.eulerAngles.z);
        } else if(isTemple){

            transform.rotation = Quaternion.Euler(0f, 0f, target.rotation.eulerAngles.z);

        }else {

            transform.rotation = Quaternion.Euler(0f, 0f, target.rotation.eulerAngles.z);

        }
        //transform.LookAt (new Vector3(transform.position.x, transform.position.z + 1000000f, -transform.position.y), Vector3.up);
        //transform.RotateAround(gameObject.transform.position, Vector3.forward, target.transform.rotation.z);


        //gameObject.transform.rotation.eulerAngles = new Vector3 (0, 0, -camRotateScript.angle);

    }
}
