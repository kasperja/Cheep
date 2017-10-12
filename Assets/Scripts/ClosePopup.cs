using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopup : MonoBehaviour {

    public GameObject popup;
    public AudioSource buttonSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Close() {

        buttonSound.Play();
        popup.SetActive(false);


    }





}
