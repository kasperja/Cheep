using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeScript : MonoBehaviour {
	public RotateCam rCam;
	// Use this for initialization
	void Start () {
		rCam.zoomOut = false;
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = new Vector3(rCam.transform.position.x, transform.position.y, transform.position.z);
		//transform.rotation = rCam.transform.rotation;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {






			StartCoroutine (waitNormPos());




		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {



			rCam.zoomOut = true;



		}

	}

	IEnumerator waitNormPos(){
	
		yield return new WaitForSeconds (0.2f);
		rCam.zoomOut = false;
		//yield return null;
	}
}
