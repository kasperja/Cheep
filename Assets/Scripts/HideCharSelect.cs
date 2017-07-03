using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCharSelect : MonoBehaviour {

    public GameObject popupObj;
    public GameObject popup1Obj;
    public GameObject menuObj;
    public GameObject xButtonTopObj;
    public Animator scrollViewAnimator;
    public bool startOverOnceBool = true;

    //public bool firstStart = true;
    // Use this for initialization
    void Start () {

     
        scrollViewAnimator.SetBool("startOver", false);

        
        //menuObj = GameObject.Find("Scroll View");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (popupObj.activeSelf || popup1Obj.activeSelf)
        {

            startOverOnceBool = true;
            menuObj.SetActive(true);
            xButtonTopObj.SetActive(false);


        }
        else {
            
            menuObj.SetActive(false);
            xButtonTopObj.SetActive(true);
            if (startOverOnceBool) {
                StartCoroutine(waitFalseAnimator());
                startOverOnceBool = false;

            }

        }
		
	}
    IEnumerator waitFalseAnimator() {
        yield return new WaitForSeconds(0.05f);
        scrollViewAnimator.SetBool("startOver", false);

    }
}
