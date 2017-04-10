using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindCam : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Canvas> ().worldCamera = GameObject.Find ("MainCam").GetComponent<Camera> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
