﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRotation : MonoBehaviour {

	//public RotateCam camRotateScript;
	private Transform target;
	//public float speed = 10f;
	//public RotateCam rCam;
	// Use this for initialization
	void Start () {

		target = GameObject.Find ("Main Camera").GetComponent<Transform>();

		//rCam = target.GetComponent<RotateCam> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = new Quaternion(0f, 0f, target.rotation.z - target.rotation.z / 10f, 1f);
		//transform.LookAt (new Vector3(transform.position.x, transform.position.z + 1000000f, -transform.position.y), Vector3.up);
		//transform.RotateAround(gameObject.transform.position, Vector3.forward, target.transform.rotation.z);


		//gameObject.transform.rotation.eulerAngles = new Vector3 (0, 0, -camRotateScript.angle);
		
	}
}
