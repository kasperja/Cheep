using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCharInGame : MonoBehaviour {

	public GameObject charText;
	public GameObject char1Image;
	public GameObject char2Image;
	public GameObject char3Image;
	public GameObject char4Image;
	public GameObject char5Image;

	public HUDScript hudScript;

	public bool char1UnlockedPointsOnce = true;
	public bool char2UnlockedPointsOnce = true;
	public bool char3UnlockedPointsOnce = true;
	public bool char4UnlockedPointsOnce = true;
	public bool char5UnlockedPointsOnce = true;
	public bool char6UnlockedPointsOnce = true;
	public bool char7UnlockedPointsOnce = true;
	public bool char8UnlockedPointsOnce = true;

	public AudioSource unlockSound;

	public TextFader txtFade;

	// Use this for initialization
	void Start () {

		if (ES2.Exists ("char1Unlock")) {

			char1UnlockedPointsOnce = ES2.Load<bool> ("char1Unlock");
		}

		if (ES2.Exists ("char2Unlock")) {

			char2UnlockedPointsOnce = ES2.Load<bool> ("char2Unlock");
		}

		if (ES2.Exists ("char3Unlock")) {

			char3UnlockedPointsOnce = ES2.Load<bool> ("char3Unlock");
		}

		if (ES2.Exists ("char4Unlock")) {

			char4UnlockedPointsOnce = ES2.Load<bool> ("char4Unlock");
		}

		if (ES2.Exists ("char5Unlock")) {

			char5UnlockedPointsOnce = ES2.Load<bool> ("char5Unlock");

		}

		if (ES2.Exists ("char6Unlock")) {

			char6UnlockedPointsOnce = ES2.Load<bool> ("char6Unlock");
		}

		if (ES2.Exists ("char7Unlock")) {

			char7UnlockedPointsOnce = ES2.Load<bool> ("char7Unlock");

		}

		if (ES2.Exists ("char8Unlock")) {

			char8UnlockedPointsOnce = ES2.Load<bool> ("char8Unlock");

		}


		
	}
	
	// Update is called once per frame
	void Update () {

		if (hudScript.playerScore >= 5000f && char1UnlockedPointsOnce) {
		
			


			StartCoroutine (waitUnlockPopup (charText, char1Image));

			char1UnlockedPointsOnce = false;

			ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
		}

		if (hudScript.playerScore >= 10000f && char2UnlockedPointsOnce) {




			StartCoroutine (waitUnlockPopup (charText, char2Image));

			char2UnlockedPointsOnce = false;

			ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
		}

		if (hudScript.playerScore >= 15000f && char3UnlockedPointsOnce) {




			StartCoroutine (waitUnlockPopup (charText, char3Image));

			char3UnlockedPointsOnce = false;

			ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
		}

		if (hudScript.playerScore >= 20000f && char4UnlockedPointsOnce) {

			StartCoroutine (waitUnlockPopup (charText, char4Image));

			char4UnlockedPointsOnce = false;

			ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
		}

		if (hudScript.playerScore >= 25000f && char5UnlockedPointsOnce) {

			StartCoroutine (waitUnlockPopup (charText, char5Image));

			char5UnlockedPointsOnce = false;

			ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
		}
		
	}

	IEnumerator waitUnlockPopup(GameObject popup, GameObject image) {
	
		txtFade.fadeOut = false;

		image.SetActive (true);
		popup.SetActive (true);

		unlockSound.Play ();
		yield return new WaitForSeconds (2f);

		txtFade.fadeOut = true;

		yield return new WaitForSeconds (2f); 



		image.SetActive (false);
		popup.SetActive (false);
		txtFade.fadeOut = false;
	
	}
}
