using UnityEngine;
using System.Collections;

public class EnableCol : MonoBehaviour {

	public Transform playerPos;
	Transform colPos;
	BoxCollider2D bc;
	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void Update () {

		colPos = this.transform;
		bc = gameObject.GetComponent<BoxCollider2D> ();

		if (playerPos.position.y > colPos.position.y) {

			bc.enabled = true;
		
		} else {
		
			bc.enabled = false;
		
		}



	}
}
