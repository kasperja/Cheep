using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CompleteProject
{
public class BuyThis : MonoBehaviour {
	
		
		//public purchaseChar pCharBuy;

		public int currentChar = 1;

		public GameObject buyButton1;
		public GameObject buyButton2;
		public GameObject buyButton3;
		public GameObject buyButton4;
		public GameObject buyButton5;
		public GameObject buyButton6;
		public GameObject buyButton7;
		public GameObject buyButton8;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			if (currentChar == 0) {



			} else if (currentChar == 1) {

				buyButton1.SetActive (true);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);


			}else if (currentChar == 2) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (true);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);

			}
			else if (currentChar == 3) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (true);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);

			}
			else if (currentChar == 4) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (true);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);

			}
			else if (currentChar == 5) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (true);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);

			}else if (currentChar == 6) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (true);
				buyButton7.SetActive (false);
				buyButton8.SetActive (false);

			}else if (currentChar == 7) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (true);
				buyButton8.SetActive (false);

			}else if (currentChar == 8) {

				buyButton1.SetActive (false);
				buyButton2.SetActive (false);
				buyButton3.SetActive (false);
				buyButton4.SetActive (false);
				buyButton5.SetActive (false);
				buyButton6.SetActive (false);
				buyButton7.SetActive (false);
				buyButton8.SetActive (true);

			}
			
		
	}
}
}