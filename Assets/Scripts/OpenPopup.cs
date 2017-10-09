using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPopup : MonoBehaviour {

    public GameObject popup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Open() {


        popup.SetActive(true);

    }
}
