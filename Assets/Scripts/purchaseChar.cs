using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompleteProject
{
public class purchaseChar : MonoBehaviour {

	public Purchaser purchaserScript;
		public int thisChar = 0;

		public GameObject purchasedButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCliked(){
	
			purchaserScript.thisChar = thisChar;
	
	}
		public void onConsumed(){

			purchasedButton.SetActive (true);
			gameObject.SetActive (false);

		}


	}}
