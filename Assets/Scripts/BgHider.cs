using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgHider : MonoBehaviour {

    public HideUnlockerImages hideScript;
    public GameObject bgHiderObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


       if(!bgHiderObj.activeSelf) hideScript.disableOnce = true;

	}
}
