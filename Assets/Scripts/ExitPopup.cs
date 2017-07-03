using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPopup : MonoBehaviour {
	public AudioSource buttonSound;
	public GameObject popup;

    public GameObject buyButton0;
    public GameObject buyButton1;
    public GameObject buyButton2;
    public GameObject buyButton3;
    public GameObject buyButton4;
    public GameObject buyButton5;
    public GameObject buyButton6;
    public GameObject buyButton7;
    public GameObject buyButton8;
    public GameObject buyButton9;
    public GameObject buyButton10;
    public GameObject buyButton11;
    public GameObject buyButton12;
    public GameObject buyButton13;
    public GameObject buyButton14;
    public GameObject buyButton15;
    public GameObject buyButton16;
    public GameObject buyButton17;
    public GameObject buyButton18;
    public GameObject buyButton19;
    public GameObject buyButton20;
    public GameObject buyButton21;
    public GameObject buyButton22;
    public GameObject buyButton23;
    public GameObject buyButton24;
    public GameObject buyButton25;
    public GameObject buyButton26;
    public GameObject buyButton27;
    public GameObject buyButton28;
    public GameObject buyButton29;
    public Animator scrollViewAnimator;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ExitPopupScreen(){

        scrollViewAnimator.SetBool("startOver", true);

		buttonSound.Play ();

        buyButton0.SetActive(false);
        buyButton1.SetActive(false);
        buyButton2.SetActive(false);
        buyButton3.SetActive(false);
        buyButton4.SetActive(false);
        buyButton5.SetActive(false);
        buyButton6.SetActive(false);
        buyButton7.SetActive(false);
        buyButton8.SetActive(false);
        buyButton9.SetActive(false);
        buyButton10.SetActive(false);
        buyButton11.SetActive(false);
        buyButton12.SetActive(false);
        buyButton13.SetActive(false);
        buyButton14.SetActive(false);
        buyButton15.SetActive(false);
        buyButton16.SetActive(false);
        buyButton17.SetActive(false);
        buyButton18.SetActive(false);
        buyButton19.SetActive(false);
        buyButton20.SetActive(false);
        buyButton21.SetActive(false);
        buyButton22.SetActive(false);
        buyButton23.SetActive(false);
        buyButton24.SetActive(false);
        buyButton25.SetActive(false);
        buyButton26.SetActive(false);
        buyButton27.SetActive(false);
        buyButton28.SetActive(false);
        buyButton29.SetActive(false);

        popup.SetActive (false);


	
	}
}
