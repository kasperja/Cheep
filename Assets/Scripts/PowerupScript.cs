﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerupScript : MonoBehaviour {

	HUDScript hud;
	Text plusText;


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

			plusText = GameObject.Find ("TextPlus").GetComponent<Text> ();

			plusText.text = "+ " + scoreIncreaseAmmount;

			plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col1;

			plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = true;

			StartCoroutine (deactivatePlus ());

			hud.IncreaseScore (scoreIncreaseAmmount);

			Destroy (this.gameObject);

		}
	}

	IEnumerator deactivatePlus(){
		
		plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col1;

		plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = true;

		yield return new WaitForSeconds(0.1f);

		plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = false;

		plusText.gameObject.GetComponent<TextFadeOut> ().playOncePlus = true;

		//plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col2;
		yield return null;
	
	}
}
