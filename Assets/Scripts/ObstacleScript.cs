using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	private DestroyerScript dScript;
	// Use this for initialization
	void Start () {
	
		dScript = GameObject.Find ("Destroyer Bottom").GetComponent<DestroyerScript> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();
			dScript.dieBool = true;
			//  particleHit.Play();


		}

	}
}
