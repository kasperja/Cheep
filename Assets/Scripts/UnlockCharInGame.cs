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
    public GameObject char6Image;
    public GameObject char7Image;
    public GameObject char8Image;
    public GameObject char9Image;
    public GameObject char10Image;
    public GameObject char11Image;
    public GameObject char12Image;
    public GameObject char13Image;
    public GameObject char14Image;
    public GameObject char15Image;
    public GameObject char16Image;
    public GameObject char17Image;
    public GameObject char18Image;
    public GameObject char19Image;
    public GameObject char20Image;
    public GameObject char21Image;
    public GameObject char22Image;
    public GameObject char23Image;
    public GameObject char24Image;
    public GameObject char25Image;
    public GameObject char26Image;
    public GameObject char27Image;
    public GameObject char28Image;
    public GameObject char29Image;
    

    public HUDScript hudScript;

    public bool char1UnlockedPointsOnce = true;
    public bool char2UnlockedPointsOnce = true;
    public bool char3UnlockedPointsOnce = true;
    public bool char4UnlockedPointsOnce = true;
    public bool char5UnlockedPointsOnce = true;
    public bool char6UnlockedPointsOnce = true;
    public bool char7UnlockedPointsOnce = true;
    public bool char8UnlockedPointsOnce = true;
    public bool char9UnlockedPointsOnce = true;
    public bool char10UnlockedPointsOnce = true;
    public bool char11UnlockedPointsOnce = true;
    public bool char12UnlockedPointsOnce = true;
    public bool char13UnlockedPointsOnce = true;
    public bool char14UnlockedPointsOnce = true;
    public bool char15UnlockedPointsOnce = true;
    public bool char16UnlockedPointsOnce = true;
    public bool char17UnlockedPointsOnce = true;
    public bool char18UnlockedPointsOnce = true;
    public bool char19UnlockedPointsOnce = true;
    public bool char20UnlockedPointsOnce = true;
    public bool char21UnlockedPointsOnce = true;
    public bool char22UnlockedPointsOnce = true;
    public bool char23UnlockedPointsOnce = true;
    public bool char24UnlockedPointsOnce = true;
    public bool char25UnlockedPointsOnce = true;
    public bool char26UnlockedPointsOnce = true;
    public bool char27UnlockedPointsOnce = true;
    public bool char28UnlockedPointsOnce = true;
    public bool char29UnlockedPointsOnce = true;
    

    public AudioSource unlockSound;
    public AudioSource unlockSoundApplause;

    public TextFader txtFade;

	public SpawnScriptUnlocker spawnUnlocker;

	// Use this for initialization
	void Start () {

		if (ES2.Exists("char1Unlock"))
        {

            char1UnlockedPointsOnce = ES2.Load<bool>("char1Unlock");
        }

        if (ES2.Exists("char2Unlock"))
        {

            char2UnlockedPointsOnce = ES2.Load<bool>("char2Unlock");
        }

        if (ES2.Exists("char3Unlock"))
        {

            char3UnlockedPointsOnce = ES2.Load<bool>("char3Unlock");
        }

        if (ES2.Exists("char4Unlock"))
        {

            char4UnlockedPointsOnce = ES2.Load<bool>("char4Unlock");
        }

        if (ES2.Exists("char5Unlock"))
        {

            char5UnlockedPointsOnce = ES2.Load<bool>("char5Unlock");

        }

        if (ES2.Exists("char6Unlock"))
        {

            char6UnlockedPointsOnce = ES2.Load<bool>("char6Unlock");
        }

        if (ES2.Exists("char7Unlock"))
        {

            char7UnlockedPointsOnce = ES2.Load<bool>("char7Unlock");

        }

        if (ES2.Exists("char8Unlock"))
        {

            char8UnlockedPointsOnce = ES2.Load<bool>("char8Unlock");

        }

        if (ES2.Exists("char9Unlock"))
        {

            char9UnlockedPointsOnce = ES2.Load<bool>("char9Unlock");
        }

        if (ES2.Exists("char10Unlock"))
        {

            char10UnlockedPointsOnce = ES2.Load<bool>("char10Unlock");
        }

        if (ES2.Exists("char11Unlock"))
        {

            char11UnlockedPointsOnce = ES2.Load<bool>("char11Unlock");
        }

        if (ES2.Exists("char12Unlock"))
        {

            char12UnlockedPointsOnce = ES2.Load<bool>("char12Unlock");
        }

        if (ES2.Exists("char13Unlock"))
        {

            char13UnlockedPointsOnce = ES2.Load<bool>("char13Unlock");

        }

        if (ES2.Exists("char14Unlock"))
        {

            char14UnlockedPointsOnce = ES2.Load<bool>("char14Unlock");
        }

        if (ES2.Exists("char15Unlock"))
        {

            char15UnlockedPointsOnce = ES2.Load<bool>("char15Unlock");

        }

        if (ES2.Exists("char16Unlock"))
        {

            char16UnlockedPointsOnce = ES2.Load<bool>("char16Unlock");

        }

        if (ES2.Exists("char17Unlock"))
        {

            char17UnlockedPointsOnce = ES2.Load<bool>("char17Unlock");
        }

        if (ES2.Exists("char18Unlock"))
        {

            char18UnlockedPointsOnce = ES2.Load<bool>("char18Unlock");
        }

        if (ES2.Exists("char19Unlock"))
        {

            char19UnlockedPointsOnce = ES2.Load<bool>("char19Unlock");

        }

        if (ES2.Exists("char20Unlock"))
        {

            char20UnlockedPointsOnce = ES2.Load<bool>("char20Unlock");
        }

        if (ES2.Exists("char21Unlock"))
        {

            char21UnlockedPointsOnce = ES2.Load<bool>("char21Unlock");

        }

        if (ES2.Exists("char22Unlock"))
        {

            char22UnlockedPointsOnce = ES2.Load<bool>("char22Unlock");

        }

        if (ES2.Exists("char23Unlock"))
        {

            char23UnlockedPointsOnce = ES2.Load<bool>("char23Unlock");
        }

        if (ES2.Exists("char24Unlock"))
        {

            char24UnlockedPointsOnce = ES2.Load<bool>("char24Unlock");
        }

        if (ES2.Exists("char25Unlock"))
        {

            char25UnlockedPointsOnce = ES2.Load<bool>("char25Unlock");
        }

        if (ES2.Exists("char26Unlock"))
        {

            char26UnlockedPointsOnce = ES2.Load<bool>("char26Unlock");
        }

        if (ES2.Exists("char27Unlock"))
        {

            char27UnlockedPointsOnce = ES2.Load<bool>("char27Unlock");

        }

        if (ES2.Exists("char28Unlock"))
        {

            char28UnlockedPointsOnce = ES2.Load<bool>("char28Unlock");
        }

        if (ES2.Exists("char29Unlock"))
        {

            char29UnlockedPointsOnce = ES2.Load<bool>("char29Unlock");

        }


		
	}
	
	// Update is called once per frame
	void Update () {



		if (spawnUnlocker.char1UnlockedPointsOnceThisGame && char1UnlockedPointsOnce) {
		
			


			StartCoroutine (waitUnlockPopup (charText, char1Image));

			char1UnlockedPointsOnce = false;

			//ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
		}

		if (spawnUnlocker.char2UnlockedPointsOnceThisGame && char2UnlockedPointsOnce) {




			StartCoroutine (waitUnlockPopup (charText, char2Image));

			char2UnlockedPointsOnce = false;

			//ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
		}

		if (spawnUnlocker.char3UnlockedPointsOnceThisGame && char3UnlockedPointsOnce) {




			StartCoroutine (waitUnlockPopup (charText, char3Image));

			char3UnlockedPointsOnce = false;

			//ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
		}

		if (spawnUnlocker.char4UnlockedPointsOnceThisGame && char4UnlockedPointsOnce) {

			StartCoroutine (waitUnlockPopup (charText, char4Image));

			char4UnlockedPointsOnce = false;

			//ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
		}

		if (spawnUnlocker.char5UnlockedPointsOnceThisGame && char5UnlockedPointsOnce) {

			StartCoroutine (waitUnlockPopup (charText, char5Image));

            char5UnlockedPointsOnce = false;

			//ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
		}
        if (spawnUnlocker.char6UnlockedPointsOnceThisGame && char6UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char6Image));

            char6UnlockedPointsOnce = false;

            //ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
        }

        if (spawnUnlocker.char7UnlockedPointsOnceThisGame && char7UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char7Image));

            char7UnlockedPointsOnce = false;

            //ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
        }

        if (spawnUnlocker.char8UnlockedPointsOnceThisGame && char8UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char8Image));

            char8UnlockedPointsOnce = false;

            //ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
        }

        if (spawnUnlocker.char9UnlockedPointsOnceThisGame && char9UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char9Image));

            char9UnlockedPointsOnce = false;

            //ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
        }

        if (spawnUnlocker.char10UnlockedPointsOnceThisGame && char10UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char10Image));

            char10UnlockedPointsOnce = false;

            //ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
        }
        if (spawnUnlocker.char11UnlockedPointsOnceThisGame && char11UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char11Image));

            char11UnlockedPointsOnce = false;

            //ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
        }

        if (spawnUnlocker.char12UnlockedPointsOnceThisGame && char12UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char12Image));

            char12UnlockedPointsOnce = false;

            //ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
        }

        if (spawnUnlocker.char13UnlockedPointsOnceThisGame && char13UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char13Image));

            char13UnlockedPointsOnce = false;

            //ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
        }

        if (spawnUnlocker.char14UnlockedPointsOnceThisGame && char14UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char14Image));

            char14UnlockedPointsOnce = false;

            //ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
        }

        if (spawnUnlocker.char15UnlockedPointsOnceThisGame && char15UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char15Image));

            char15UnlockedPointsOnce = false;

            //ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
        }
        

        if (spawnUnlocker.char16UnlockedPointsOnceThisGame && char16UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char16Image));

            char16UnlockedPointsOnce = false;

            //ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
        }

        if (spawnUnlocker.char17UnlockedPointsOnceThisGame && char17UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char17Image));

            char17UnlockedPointsOnce = false;

            //ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
        }

        if (spawnUnlocker.char18UnlockedPointsOnceThisGame && char18UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char18Image));

            char18UnlockedPointsOnce = false;

            //ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
        }

        if (spawnUnlocker.char19UnlockedPointsOnceThisGame && char19UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char19Image));

            char19UnlockedPointsOnce = false;

            //ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
        }
        

        if (spawnUnlocker.char20UnlockedPointsOnceThisGame && char20UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char20Image));

            char20UnlockedPointsOnce = false;

            //ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
        }

        if (spawnUnlocker.char21UnlockedPointsOnceThisGame && char21UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char21Image));

            char21UnlockedPointsOnce = false;

            //ES2.Save (char3UnlockedPointsOnce, "char3Unlock");
        }

        if (spawnUnlocker.char22UnlockedPointsOnceThisGame && char22UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char22Image));

            char22UnlockedPointsOnce = false;

            //ES2.Save (char4UnlockedPointsOnce, "char4Unlock");
        }

        if (spawnUnlocker.char23UnlockedPointsOnceThisGame && char23UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char23Image));

            char23UnlockedPointsOnce = false;

            //ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
        }
        if (spawnUnlocker.char24UnlockedPointsOnceThisGame && char24UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char24Image));

            char24UnlockedPointsOnce = false;

            //ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
        }

        if (spawnUnlocker.char25UnlockedPointsOnceThisGame && char25UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char25Image));

            char25UnlockedPointsOnce = false;

            //ES2.Save (char2UnlockedPointsOnce, "char2Unlock");
        }

        if (spawnUnlocker.char26UnlockedPointsOnceThisGame && char26UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char26Image));

       //     ES2.Save(char3UnlockedPointsOnce, "char3Unlock");

            char26UnlockedPointsOnce = false;

            
        }

        if (spawnUnlocker.char27UnlockedPointsOnceThisGame && char27UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char27Image));

           // ES2.Save(char4UnlockedPointsOnce, "char4Unlock");

            char27UnlockedPointsOnce = false;

        }

        if (spawnUnlocker.char28UnlockedPointsOnceThisGame && char28UnlockedPointsOnce)
        {

            StartCoroutine(waitUnlockPopup(charText, char28Image));

            char28UnlockedPointsOnce = false;

         //   ES2.Save (char5UnlockedPointsOnce, "char5Unlock");
        }
        if (spawnUnlocker.char29UnlockedPointsOnceThisGame && char29UnlockedPointsOnce)
        {




            StartCoroutine(waitUnlockPopup(charText, char29Image));

            char29UnlockedPointsOnce = false;

          //  ES2.Save (char1UnlockedPointsOnce, "char1Unlock");
        }

    }

	IEnumerator waitUnlockPopup(GameObject popup, GameObject image) {
	
		//txtFade.fadeOut = false;

		image.SetActive (true);
		popup.SetActive (true);

		unlockSound.Play ();
        unlockSoundApplause.Play();

        spawnUnlocker.DestroyAllObjectsUnlocker();
        spawnUnlocker.DestroyAllObjects();
		yield return new WaitForSeconds (3.5f);

		//txtFade.fadeOut = true;

		yield return new WaitForSeconds (1f); 



		image.SetActive (false);
		popup.SetActive (false);
		//txtFade.fadeOut = false;
	
	}
}
