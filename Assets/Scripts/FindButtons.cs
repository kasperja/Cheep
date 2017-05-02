using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindButtons : MonoBehaviour {

	public Purchaser purScript;
	// Use this for initialization
	public void FindInActive () {


		Transform[] transformButtons = GameObject.Find ("Content").GetComponentsInChildren<Transform> (true);

		foreach (Transform t in transformButtons) {


			if (t.gameObject.name == "Char0") {

				purScript.char0button = t.gameObject;

			}
			if (t.gameObject.name == "Char0d") {

				purScript.char0buttonD = t.gameObject;

			}if (t.gameObject.name == "Char1") {

				purScript.char1button = t.gameObject;

			}
			if (t.gameObject.name == "Char1d") {

				purScript.char1buttonD = t.gameObject;

			}if (t.gameObject.name == "Char2") {

				purScript.char2button = t.gameObject;

			}
			if (t.gameObject.name == "Char2d") {

				purScript.char2buttonD = t.gameObject;

			}if (t.gameObject.name == "Char3") {

				purScript.char3button = t.gameObject;

			}
			if (t.gameObject.name == "Char3d") {

				purScript.char3buttonD = t.gameObject;

			}if (t.gameObject.name == "Char4") {

				purScript.char4button = t.gameObject;

			}
			if (t.gameObject.name == "Char4d") {

				purScript.char4buttonD = t.gameObject;

			}if (t.gameObject.name == "Char5") {

				purScript.char5button = t.gameObject;

			}
			if (t.gameObject.name == "Char5d") {

				purScript.char5buttonD = t.gameObject;

			}if (t.gameObject.name == "Char6") {

				purScript.char6button = t.gameObject;

			}
			if (t.gameObject.name == "Char6d") {

				purScript.char6buttonD = t.gameObject;

			}if (t.gameObject.name == "Char7") {

				purScript.char7button = t.gameObject;

			}
			if (t.gameObject.name == "Char7d") {

				purScript.char7buttonD = t.gameObject;

			}
			if (t.gameObject.name == "Char8") {

				purScript.char8button = t.gameObject;

			}
			if (t.gameObject.name == "Char8d") {

				purScript.char8buttonD = t.gameObject;

			}

		}


	}

	void Start(){
		Transform[] transformButtons = GameObject.Find ("Content").GetComponentsInChildren<Transform> (true);

		foreach (Transform t in transformButtons) {


			if (t.gameObject.name == "Char0") {

				purScript.char0button = t.gameObject;

			}
			if (t.gameObject.name == "Char0d") {

				purScript.char0buttonD = t.gameObject;

			}if (t.gameObject.name == "Char1") {

				purScript.char1button = t.gameObject;

			}
			if (t.gameObject.name == "Char1d") {

				purScript.char1buttonD = t.gameObject;

			}if (t.gameObject.name == "Char2") {

				purScript.char2button = t.gameObject;

			}
			if (t.gameObject.name == "Char2d") {

				purScript.char2buttonD = t.gameObject;

			}if (t.gameObject.name == "Char3") {

				purScript.char3button = t.gameObject;

			}
			if (t.gameObject.name == "Char3d") {

				purScript.char3buttonD = t.gameObject;

			}if (t.gameObject.name == "Char4") {

				purScript.char4button = t.gameObject;

			}
			if (t.gameObject.name == "Char4d") {

				purScript.char4buttonD = t.gameObject;

			}if (t.gameObject.name == "Char5") {

				purScript.char5button = t.gameObject;

			}
			if (t.gameObject.name == "Char5d") {

				purScript.char5buttonD = t.gameObject;

			}if (t.gameObject.name == "Char6") {

				purScript.char6button = t.gameObject;

			}
			if (t.gameObject.name == "Char6d") {

				purScript.char6buttonD = t.gameObject;

			}if (t.gameObject.name == "Char7") {

				purScript.char7button = t.gameObject;

			}
			if (t.gameObject.name == "Char7d") {

				purScript.char7buttonD = t.gameObject;

			}
			if (t.gameObject.name == "Char8") {

				purScript.char8button = t.gameObject;

			}
			if (t.gameObject.name == "Char8d") {

				purScript.char8buttonD = t.gameObject;

			}

		}




	}
	// Update is called once per frame
	void Update () {
		
	}
}
