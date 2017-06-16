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
            if (t.gameObject.name == "Char9")
            {

                purScript.char9button = t.gameObject;

            }
            if (t.gameObject.name == "Char9d")
            {

                purScript.char9buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char10")
            {

                purScript.char10button = t.gameObject;

            }
            if (t.gameObject.name == "Char10d")
            {

                purScript.char10buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char11")
            {

                purScript.char11button = t.gameObject;

            }
            if (t.gameObject.name == "Char11d")
            {

                purScript.char11buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char12")
            {

                purScript.char12button = t.gameObject;

            }
            if (t.gameObject.name == "Char12d")
            {

                purScript.char12buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char13")
            {

                purScript.char13button = t.gameObject;

            }
            if (t.gameObject.name == "Char13d")
            {

                purScript.char13buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char14")
            {

                purScript.char14button = t.gameObject;

            }
            if (t.gameObject.name == "Char14d")
            {

                purScript.char14buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char15")
            {

                purScript.char15button = t.gameObject;

            }
            if (t.gameObject.name == "Char15d")
            {

                purScript.char15buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char16")
            {

                purScript.char16button = t.gameObject;

            }
            if (t.gameObject.name == "Char16d")
            {

                purScript.char16buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char17")
            {

                purScript.char17button = t.gameObject;

            }
            if (t.gameObject.name == "Char17d")
            {

                purScript.char17buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char18")
            {

                purScript.char18button = t.gameObject;

            }
            if (t.gameObject.name == "Char18d")
            {

                purScript.char18buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char19")
            {

                purScript.char19button = t.gameObject;

            }
            if (t.gameObject.name == "Char19d")
            {

                purScript.char19buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char20")
            {

                purScript.char20button = t.gameObject;

            }
            if (t.gameObject.name == "Char20d")
            {

                purScript.char20buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char21")
            {

                purScript.char21button = t.gameObject;

            }
            if (t.gameObject.name == "Char21d")
            {

                purScript.char21buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char22")
            {

                purScript.char22button = t.gameObject;

            }
            if (t.gameObject.name == "Char22d")
            {

                purScript.char22buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char23")
            {

                purScript.char23button = t.gameObject;

            }
            if (t.gameObject.name == "Char23d")
            {

                purScript.char23buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char24")
            {

                purScript.char24button = t.gameObject;

            }
            if (t.gameObject.name == "Char24d")
            {

                purScript.char24buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char25")
            {

                purScript.char25button = t.gameObject;

            }
            if (t.gameObject.name == "Char25d")
            {

                purScript.char25buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char26")
            {

                purScript.char26button = t.gameObject;

            }
            if (t.gameObject.name == "Char26d")
            {

                purScript.char26buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char27")
            {

                purScript.char27button = t.gameObject;

            }
            if (t.gameObject.name == "Char27d")
            {

                purScript.char27buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char28")
            {

                purScript.char28button = t.gameObject;

            }
            if (t.gameObject.name == "Char28d")
            {

                purScript.char28buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char29")
            {

                purScript.char29button = t.gameObject;

            }
            if (t.gameObject.name == "Char29d")
            {

                purScript.char29buttonD = t.gameObject;

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
            if (t.gameObject.name == "Char9")
            {

                purScript.char9button = t.gameObject;

            }
            if (t.gameObject.name == "Char9d")
            {

                purScript.char9buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char10")
            {

                purScript.char10button = t.gameObject;

            }
            if (t.gameObject.name == "Char10d")
            {

                purScript.char10buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char11")
            {

                purScript.char11button = t.gameObject;

            }
            if (t.gameObject.name == "Char11d")
            {

                purScript.char11buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char12")
            {

                purScript.char12button = t.gameObject;

            }
            if (t.gameObject.name == "Char12d")
            {

                purScript.char12buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char13")
            {

                purScript.char13button = t.gameObject;

            }
            if (t.gameObject.name == "Char13d")
            {

                purScript.char13buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char14")
            {

                purScript.char14button = t.gameObject;

            }
            if (t.gameObject.name == "Char14d")
            {

                purScript.char14buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char15")
            {

                purScript.char15button = t.gameObject;

            }
            if (t.gameObject.name == "Char15d")
            {

                purScript.char15buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char16")
            {

                purScript.char16button = t.gameObject;

            }
            if (t.gameObject.name == "Char16d")
            {

                purScript.char16buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char17")
            {

                purScript.char17button = t.gameObject;

            }
            if (t.gameObject.name == "Char17d")
            {

                purScript.char17buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char18")
            {

                purScript.char18button = t.gameObject;

            }
            if (t.gameObject.name == "Char18d")
            {

                purScript.char18buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char19")
            {

                purScript.char19button = t.gameObject;

            }
            if (t.gameObject.name == "Char19d")
            {

                purScript.char19buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char20")
            {

                purScript.char20button = t.gameObject;

            }
            if (t.gameObject.name == "Char20d")
            {

                purScript.char20buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char21")
            {

                purScript.char21button = t.gameObject;

            }
            if (t.gameObject.name == "Char21d")
            {

                purScript.char21buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char22")
            {

                purScript.char22button = t.gameObject;

            }
            if (t.gameObject.name == "Char22d")
            {

                purScript.char22buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char23")
            {

                purScript.char23button = t.gameObject;

            }
            if (t.gameObject.name == "Char23d")
            {

                purScript.char23buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char24")
            {

                purScript.char24button = t.gameObject;

            }
            if (t.gameObject.name == "Char24d")
            {

                purScript.char24buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char25")
            {

                purScript.char25button = t.gameObject;

            }
            if (t.gameObject.name == "Char25d")
            {

                purScript.char25buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char26")
            {

                purScript.char26button = t.gameObject;

            }
            if (t.gameObject.name == "Char26d")
            {

                purScript.char26buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char27")
            {

                purScript.char27button = t.gameObject;

            }
            if (t.gameObject.name == "Char27d")
            {

                purScript.char27buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char28")
            {

                purScript.char28button = t.gameObject;

            }
            if (t.gameObject.name == "Char28d")
            {

                purScript.char28buttonD = t.gameObject;

            }
            if (t.gameObject.name == "Char29")
            {

                purScript.char29button = t.gameObject;

            }
            if (t.gameObject.name == "Char29d")
            {

                purScript.char29buttonD = t.gameObject;

            }

        }




	}
	// Update is called once per frame
	void Update () {
		
	}
}
