using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCharSelect : MonoBehaviour {

    public GameObject popupObj;
    public GameObject menuObj;
    public GameObject xButtonTopObj;
	// Use this for initialization
	void Start () {

        //menuObj = GameObject.Find("Scroll View");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (popupObj.activeSelf)
        {

            menuObj.SetActive(true);
            xButtonTopObj.SetActive(false);


        }
        else {
            menuObj.SetActive(false);
            xButtonTopObj.SetActive(true);


        }
		
	}
}
