using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCharSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject charMenu = (GameObject)Instantiate(Resources.Load("CharSelectMenu")) as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
