using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideCharSelect : MonoBehaviour {

    public GameObject popupObj;
    public GameObject popup1Obj;
    public GameObject menuObj;
    public GameObject xButtonTopObj;
    public Animator scrollViewAnimator;
    public bool startOverOnceBool = true;
    public GameObject mask;
    public Image leaderboard;

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
            leaderboard.enabled = false;
            //mask.SetActive(false);
            startOverOnceBool = true;
            menuObj.SetActive(true);
            xButtonTopObj.SetActive(false);
            


        }
        else {

            //mask.SetActive(true);
            leaderboard.enabled = true;
            menuObj.SetActive(false);
            xButtonTopObj.SetActive(true);
            if (startOverOnceBool) {
                StartCoroutine(waitFalseAnimator());
                startOverOnceBool = false;

            }

        }
		
	}
    IEnumerator waitFalseAnimator() {
        //scrollViewAnimator.SetBool("startOver", true);
        yield return new WaitForSeconds(0.05f);
        scrollViewAnimator.SetBool("startOver", false);

    }
}
