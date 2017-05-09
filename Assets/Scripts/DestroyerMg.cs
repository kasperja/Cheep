using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerMg : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D other){

		//Debug.Log ("tree!");

		//objm.Release (other.gameObject);
		Destroy (other.gameObject);




	}
}
