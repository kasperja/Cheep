﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerupUnlockerScript : MonoBehaviour {

	//HUDScript hud;
	//Text plusText;

	Text TextPickup;

	SpawnScriptUnlocker spawnUnlocker;

	public float pickupAmmount = 1f;

	public float scoreIncreaseAmmount = 1000f;

    public bool setFalse = false;
	//public HUDScript hudScript;

	void Start(){

        spawnUnlocker = GameObject.Find("PowerupSpawn top unlocker").GetComponent<SpawnScriptUnlocker>();

        spawnUnlocker.UIanimator.SetBool("pickedup", false);
        /*if (transform.rotation.z >= -90f) {
			transform.Rotate (Vector3.forward * 100f * Time.deltaTime, Space.Self);
		} else if(transform.rotation.z <= 90f){
			
			transform.Rotate (Vector3.forward * -100f * Time.deltaTime, Space.Self);

		}*/

    }

    void Update() {

        if (spawnUnlocker.UIanimator.GetCurrentAnimatorStateInfo(0).IsName("PickupAnimUI")) {


            if (spawnUnlocker.UIanimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                spawnUnlocker.UIanimator.SetBool("pickedup", false);
                
            }
        }

    }

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {



			//spawnUnlocker = GameObject.Find ("PowerupSpawn top unlocker").GetComponent<SpawnScriptUnlocker> ();

			spawnUnlocker.numberOfPickups += 1f;

            spawnUnlocker.UIanimator.SetBool("pickedup", true);

           if(!spawnUnlocker.allCharsUnlocked) spawnUnlocker.pickupUnlockerSound.Play();


            

           // StartCoroutine(waitFalseUI());

            //hud = GameObject.Find ("Main Camera").GetComponent<HUDScript> ();

            //plusText = GameObject.Find ("TextPlus").GetComponent<Text> ();

            //plusText.text = "+ " + scoreIncreaseAmmount;

            //plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col1;

            //plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = true;

            //StartCoroutine (deactivatePlus ());

            //hud.IncreaseScore (scoreIncreaseAmmount);
            

            Destroy (this.gameObject);

		}
	}

   /* IEnumerator waitFalseUI() {

        yield return new WaitForSeconds(0.1f);
        setFalse = true;
        


    }*/

	/*IEnumerator deactivatePlus(){

		plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col1;

		plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = true;

		yield return new WaitForSeconds(0.1f);

		plusText.gameObject.GetComponent<TextFadeOut> ().txtFadeActivate = false;

		plusText.gameObject.GetComponent<TextFadeOut> ().playOncePlus = true;

		//plusText.color = plusText.gameObject.GetComponent<TextFadeOut> ().col2;
		yield return null;

	}*/
}
