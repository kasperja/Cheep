using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
public class purchaseChar : MonoBehaviour {

	public Purchaser purchaserScript;
		public int thisChar = 0;

		public GameObject purchasedButton;
		public GameObject popup;
		public BuyThis buyThisScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCliked(){
	
			buyThisScript.currentChar = thisChar;
			purchaserScript.thisChar = thisChar;

			popup.SetActive (true);
	
	}
		public void onConsumed(){

			purchasedButton.SetActive (true);
			gameObject.SetActive (false);
			popup.SetActive (false);

		}


	}}
