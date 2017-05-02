using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerTree : MonoBehaviour {

	//public ObjectPoolManager objm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		//Debug.Log ("tree!");

		//objm.Release (other.gameObject);
		Destroy (other.gameObject);

		


	}


}
