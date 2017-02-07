using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HUDScript hud;

	public float scoreIncreaseAmmount = 1000f;

	//public HUDScript hudScript;

	void Update(){
	
		/*if (transform.rotation.z >= -90f) {
			transform.Rotate (Vector3.forward * 100f * Time.deltaTime, Space.Self);
		} else if(transform.rotation.z <= 90f){
			
			transform.Rotate (Vector3.forward * -100f * Time.deltaTime, Space.Self);

		}*/
	
	}

	void OnTriggerEnter2D(Collider2D other){
	
		if (other.tag == "Player") {
			
			hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();
			hud.IncreaseScore (scoreIncreaseAmmount);
			Destroy (this.gameObject);

		}
	}
}
