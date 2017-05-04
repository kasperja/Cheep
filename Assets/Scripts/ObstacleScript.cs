using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	private DestroyerScript dScript;
	private PlatformerCharacter2D pc2D;
	// Use this for initialization
	void Start () {
	
		dScript = GameObject.Find ("Destroyer Bottom").GetComponent<DestroyerScript> ();
		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {

			//Debug.Log (pc2D.isRocket);
			
			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();
			if(Time.timeScale<=1f){

				dScript.dieBool = true;
			
			}else{

				gameObject.GetComponent<BoxCollider2D> ().enabled = false;
				Destroy (this.gameObject);

			}
			//  particleHit.Play();


		}

	}
}
