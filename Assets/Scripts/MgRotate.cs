using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MgRotate : MonoBehaviour {

	private Transform mainCam;
	// Use this for initialization
	void Start () {

		mainCam = GameObject.Find ("Main Camera").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		


		transform.rotation = Quaternion.RotateTowards(transform.rotation, mainCam.rotation, 0.001f);
		//transform.rotation = Vector3.RotateTowards(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z),new Vector3(transform.rotation.x, transform.rotation.y, mainCam.transform.rotation.z), 2f*Time.deltaTime, 0f);
	}
}
