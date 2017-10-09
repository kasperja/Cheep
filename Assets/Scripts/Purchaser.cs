using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;


// Placing the Purchaser class in the CompleteProject namespace allows it to interact with ScoreManager, 
// one of the existing Survival Shooter scripts.
//namespace CompleteProject
//{
	// Deriving the Purchaser class from IStoreListener enables it to receive messages from Unity Purchasing.
	public class Purchaser : MonoBehaviour, IStoreListener
	{
		//public static Purchaser Instance{ set; get;}

		private static IStoreController m_StoreController;          // The Unity Purchasing system.
		private static IExtensionProvider m_StoreExtensionProvider; // The store-specific Purchasing subsystems.

		// Product identifiers for all products capable of being purchased: 
		// "convenience" general identifiers for use with Purchasing, and their store-specific identifier 
		// counterparts for use with and outside of Unity Purchasing. Define store-specific identifiers 
		// also on each platform's publisher dashboard (iTunes Connect, Google Play Developer Console, etc.)

		// General product identifiers for the consumable, non-consumable, and subscription products.
		// Use these handles in the code to reference which product to purchase. Also use these values 
		// when defining the Product Identifiers on the store. Except, for illustration purposes, the 
		// kProductIDSubscription - it has custom Apple and Google identifiers. We declare their store-
		// specific mapping to Unity Purchasing's AddProduct, below.
		public static string kProductIDConsumable =    "consumable";   
		public static string kProductIDNonConsumable = "nonconsumable";
		public static string kProductIDCharacter1 = "character1";
		public static string kProductIDCharacter2 = "character2";
		public static string kProductIDCharacter3 = "character3";
		public static string kProductIDCharacter4 = "character4";
		public static string kProductIDCharacter5 = "character5";
		public static string kProductIDCharacter6 = "character6";
		public static string kProductIDCharacter7 = "character7";
		public static string kProductIDCharacter8 = "character8";
        public static string kProductIDCharacter9 = "character9";
        public static string kProductIDCharacter10 = "character10";
        public static string kProductIDCharacter11 = "character11";
        public static string kProductIDCharacter12 = "character12";
        public static string kProductIDCharacter13 = "character13";
        public static string kProductIDCharacter14 = "character14";
        public static string kProductIDCharacter15 = "character15";
        public static string kProductIDCharacter16 = "character16";
        public static string kProductIDCharacter17 = "character17";
        public static string kProductIDCharacter18 = "character18";
        public static string kProductIDCharacter19 = "character19";
        public static string kProductIDCharacter20 = "character20";
        public static string kProductIDCharacter21 = "character21";
        public static string kProductIDCharacter22 = "character22";
        public static string kProductIDCharacter23 = "character23";
        public static string kProductIDCharacter24 = "character24";
        public static string kProductIDCharacter25 = "character25";
        public static string kProductIDCharacter26 = "character26";
        public static string kProductIDCharacter27 = "character27";
        public static string kProductIDCharacter28 = "character28";
        public static string kProductIDCharacter29 = "character29";

    public float[] pointsForNextChar;

    public static string kProductIDSubscription =  "subscription"; 

		// Apple App Store-specific product identifier for the subscription product.
		private static string kProductNameAppleSubscription =  "com.unity3d.subscription.new";

		// Google Play Store-specific product identifier subscription product.
		private static string kProductNameGooglePlaySubscription =  "com.unity3d.subscription.original"; 

		/*public bool char0unlocked = true;
		public bool char1unlocked = false;
		public bool char2unlocked = false;
		public bool char3unlocked = false;
		public bool char4unlocked = false;
		public bool char5unlocked = false;
		public bool char6unlocked = false;
		public bool char7unlocked = false;
		public bool char8unlocked = false;
		public bool char9unlocked = false;*/

	public GameObject char0button;
	public GameObject char1button;
	public GameObject char2button;
	public GameObject char3button;
	public GameObject char4button;
	public GameObject char5button;
	public GameObject char6button;
	public GameObject char7button;
	public GameObject char8button;
    public GameObject char9button;
    public GameObject char10button;
    public GameObject char11button;
    public GameObject char12button;
    public GameObject char13button;
    public GameObject char14button;
    public GameObject char15button;
    public GameObject char16button;
    public GameObject char17button;
    public GameObject char18button;
    public GameObject char19button;
    public GameObject char20button;
    public GameObject char21button;
    public GameObject char22button;
    public GameObject char23button;
    public GameObject char24button;
    public GameObject char25button;
    public GameObject char26button;
    public GameObject char27button;
    public GameObject char28button;
    public GameObject char29button;
    
    //public GameObject char9button;

    public GameObject char0buttonD;
	public GameObject char1buttonD;
	public GameObject char2buttonD;
	public GameObject char3buttonD;
	public GameObject char4buttonD;
	public GameObject char5buttonD;
	public GameObject char6buttonD;
	public GameObject char7buttonD;
	public GameObject char8buttonD;
    public GameObject char9buttonD;
    public GameObject char10buttonD;
    public GameObject char11buttonD;
    public GameObject char12buttonD;
    public GameObject char13buttonD;
    public GameObject char14buttonD;
    public GameObject char15buttonD;
    public GameObject char16buttonD;
    public GameObject char17buttonD;
    public GameObject char18buttonD;
    public GameObject char19buttonD;
    public GameObject char20buttonD;
    public GameObject char21buttonD;
    public GameObject char22buttonD;
    public GameObject char23buttonD;
    public GameObject char24buttonD;
    public GameObject char25buttonD;
    public GameObject char26buttonD;
    public GameObject char27buttonD;
    public GameObject char28buttonD;
    public GameObject char29buttonD;
    //public GameObject char9buttonD;
    public GameObject popup;

		public int thisChar = 0;

		public int highscore = 0;

	/*	public int score1 = 5000;
		public int score2 = 10000;
		public int score3 = 15000;
		public int score4 = 20000;
		public int score5 = 25000;
		public int score6 = 30000;
		public int score7 = 35000;
		public int score8 = 40000;*/

	public bool char1Unlocked = false;
    public bool char2Unlocked = false;
    public bool char3Unlocked = false;
    public bool char4Unlocked = false;
    public bool char5Unlocked = false;
    public bool char6Unlocked = false;
    public bool char7Unlocked = false;
    public bool char8Unlocked = false;
    public bool char9Unlocked = false;
    public bool char10Unlocked = false;
    public bool char11Unlocked = false;
    public bool char12Unlocked = false;
    public bool char13Unlocked = false;
    public bool char14Unlocked = false;
    public bool char15Unlocked = false;
    public bool char16Unlocked = false;
    public bool char17Unlocked = false;
    public bool char18Unlocked = false;
    public bool char19Unlocked = false;
    public bool char20Unlocked = false;
    public bool char21Unlocked = false;
    public bool char22Unlocked = false;
    public bool char23Unlocked = false;
    public bool char24Unlocked = false;
    public bool char25Unlocked = false;
    public bool char26Unlocked = false;
    public bool char27Unlocked = false;
    public bool char28Unlocked = false;
    public bool char29Unlocked = false;
    


    public Product cata1;

		public bool char1Purchased = false;
		public bool char2Purchased = false;
		public bool char3Purchased = false;
		public bool char4Purchased = false;
		public bool char5Purchased = false;
		public bool char6Purchased = false;
		public bool char7Purchased = false;
		public bool char8Purchased = false;
        public bool char9Purchased = false;
        public bool char10Purchased = false;
        public bool char11Purchased = false;
        public bool char12Purchased = false;
        public bool char13Purchased = false;
        public bool char14Purchased = false;
        public bool char15Purchased = false;
        public bool char16Purchased = false;
        public bool char17Purchased = false;
        public bool char18Purchased = false;
        public bool char19Purchased = false;
        public bool char20Purchased = false;
        public bool char21Purchased = false;
        public bool char22Purchased = false;
        public bool char23Purchased = false;
        public bool char24Purchased = false;
        public bool char25Purchased = false;
        public bool char26Purchased = false;
        public bool char27Purchased = false;
        public bool char28Purchased = false;
        public bool char29Purchased = false;
    

    private bool firstStart = true;

	public FindButtons findButtonsScript;

	public bool noAdsPurchased = false;

    public bool allCharsUnlocked = false;

    public int nextChar = 1;

		private void Awake(){

        InitializePurchasing();
        if (ES2.Exists("myHighscore"))highscore = ES2.Load<int> ("myHighscore");
		findButtonsScript.FindInActive ();
		//Instance = this;

		}

		void Update(){

        if (ES2.Exists("nextChar")) nextChar = ES2.Load<int>("nextChar");

        if ((char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased))
        {

            allCharsUnlocked = true;


        }



		if (char1Unlocked || char1Purchased) {

			char1button.SetActive (true);
			char1buttonD.SetActive (false);


		}
		if (char2Unlocked || char2Purchased) {

			char2button.SetActive (true);
			char2buttonD.SetActive (false);


		}

		if (char3Unlocked || char3Purchased) {

			char3button.SetActive (true);
			char3buttonD.SetActive (false);


		}

		if (char4Unlocked || char4Purchased) {

			char4button.SetActive (true);
			char4buttonD.SetActive (false);


		}

		if (char5Unlocked || char5Purchased) {

			char5button.SetActive (true);
			char5buttonD.SetActive (false);


		}
		if (char6Unlocked || char6Purchased) {

			char6button.SetActive (true);
			char6buttonD.SetActive (false);


		}
		if (char7Unlocked || char7Purchased) {

			char7button.SetActive (true);
			char7buttonD.SetActive (false);


		}
		if (char8Unlocked || char8Purchased) {

			char8button.SetActive (true);
			char8buttonD.SetActive (false);

		}
        if (char9Unlocked || char9Purchased)
        {

            char9button.SetActive(true);
            char9buttonD.SetActive(false);


        }
        if (char10Unlocked || char10Purchased)
        {

            char10button.SetActive(true);
            char10buttonD.SetActive(false);


        }

        if (char11Unlocked || char11Purchased)
        {

            char11button.SetActive(true);
            char11buttonD.SetActive(false);


        }

        if (char12Unlocked || char12Purchased)
        {

            char12button.SetActive(true);
            char12buttonD.SetActive(false);


        }

        if (char13Unlocked || char13Purchased)
        {

            char13button.SetActive(true);
            char13buttonD.SetActive(false);


        }
        if (char14Unlocked || char14Purchased)
        {

            char14button.SetActive(true);
            char14buttonD.SetActive(false);


        }
        if (char15Unlocked || char15Purchased)
        {

            char15button.SetActive(true);
            char15buttonD.SetActive(false);


        }
        if (char16Unlocked || char16Purchased)
        {

            char16button.SetActive(true);
            char16buttonD.SetActive(false);

        }
        if (char17Unlocked || char17Purchased)
        {

            char17button.SetActive(true);
            char17buttonD.SetActive(false);


        }
        if (char18Unlocked || char18Purchased)
        {

            char18button.SetActive(true);
            char18buttonD.SetActive(false);


        }

        if (char19Unlocked || char19Purchased)
        {

            char19button.SetActive(true);
            char19buttonD.SetActive(false);


        }

        if (char20Unlocked || char20Purchased)
        {

            char20button.SetActive(true);
            char20buttonD.SetActive(false);


        }

        if (char21Unlocked || char21Purchased)
        {

            char21button.SetActive(true);
            char21buttonD.SetActive(false);


        }
        if (char22Unlocked || char22Purchased)
        {

            char22button.SetActive(true);
            char22buttonD.SetActive(false);


        }
        if (char23Unlocked || char23Purchased)
        {

            char23button.SetActive(true);
            char23buttonD.SetActive(false);


        }
        if (char24Unlocked || char24Purchased)
        {

            char24button.SetActive(true);
            char24buttonD.SetActive(false);

        }
        if (char25Unlocked || char25Purchased)
        {

            char25button.SetActive(true);
            char25buttonD.SetActive(false);


        }
        if (char26Unlocked || char26Purchased)
        {

            char26button.SetActive(true);
            char26buttonD.SetActive(false);


        }

        if (char27Unlocked || char27Purchased)
        {

            char27button.SetActive(true);
            char27buttonD.SetActive(false);


        }

        if (char28Unlocked || char28Purchased)
        {

            char28button.SetActive(true);
            char28buttonD.SetActive(false);


        }

        if (char29Unlocked || char29Purchased)
        {

            char29button.SetActive(true);
            char29buttonD.SetActive(false);


        }


        if ((!char1Unlocked || !char1Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 1;
            ES2.Save(nextChar, "nextChar");
        }
        if ((char1Unlocked || char1Purchased) &&
            (!char2Unlocked && !char2Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 2;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (!char3Unlocked && !char3Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 3;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (!char4Unlocked && !char4Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 4;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (!char5Unlocked && !char5Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 5;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (!char6Unlocked && !char6Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 6;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (!char7Unlocked && !char7Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 7;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (!char8Unlocked && !char8Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 8;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (!char9Unlocked && !char9Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 9;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (!char10Unlocked && !char10Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 10;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (!char11Unlocked && !char11Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 11;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (!char12Unlocked && !char12Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 12;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (char12Unlocked || char12Purchased) &&
            (!char13Unlocked && !char13Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 13;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (char12Unlocked || char12Purchased) &&
            (char13Unlocked || char13Purchased) &&
            (!char14Unlocked && !char14Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 14;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (char12Unlocked || char12Purchased) &&
            (char13Unlocked || char13Purchased) &&
            (char14Unlocked || char14Purchased) &&
            (!char15Unlocked && !char15Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 15;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (char12Unlocked || char12Purchased) &&
            (char13Unlocked || char13Purchased) &&
            (char14Unlocked || char14Purchased) &&
            (char15Unlocked || char15Purchased) &&
            (!char16Unlocked && !char16Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 16;
            ES2.Save(nextChar, "nextChar");
        }
        if (
            (char1Unlocked || char1Purchased) &&
            (char2Unlocked || char2Purchased) &&
            (char3Unlocked || char3Purchased) &&
            (char4Unlocked || char4Purchased) &&
            (char5Unlocked || char5Purchased) &&
            (char6Unlocked || char6Purchased) &&
            (char7Unlocked || char7Purchased) &&
            (char8Unlocked || char8Purchased) &&
            (char9Unlocked || char9Purchased) &&
            (char10Unlocked || char10Purchased) &&
            (char11Unlocked || char11Purchased) &&
            (char12Unlocked || char12Purchased) &&
            (char13Unlocked || char13Purchased) &&
            (char14Unlocked || char14Purchased) &&
            (char15Unlocked || char15Purchased) &&
            (char16Unlocked || char16Purchased) &&
            (!char17Unlocked && !char17Purchased) &&
            !allCharsUnlocked)
        {
            nextChar = 17;
            ES2.Save(nextChar, "nextChar");
        }
        if (
          (char1Unlocked || char1Purchased) &&
          (char2Unlocked || char2Purchased) &&
          (char3Unlocked || char3Purchased) &&
          (char4Unlocked || char4Purchased) &&
          (char5Unlocked || char5Purchased) &&
          (char6Unlocked || char6Purchased) &&
          (char7Unlocked || char7Purchased) &&
          (char8Unlocked || char8Purchased) &&
          (char9Unlocked || char9Purchased) &&
          (char10Unlocked || char10Purchased) &&
          (char11Unlocked || char11Purchased) &&
          (char12Unlocked || char12Purchased) &&
          (char13Unlocked || char13Purchased) &&
          (char14Unlocked || char14Purchased) &&
          (char15Unlocked || char15Purchased) &&
          (char16Unlocked || char16Purchased) &&
          (char17Unlocked || char17Purchased) &&
          (!char18Unlocked && !char18Purchased) &&
          !allCharsUnlocked)
        {
            nextChar = 18;
            ES2.Save(nextChar, "nextChar");
        }
        if (
          (char1Unlocked || char1Purchased) &&
          (char2Unlocked || char2Purchased) &&
          (char3Unlocked || char3Purchased) &&
          (char4Unlocked || char4Purchased) &&
          (char5Unlocked || char5Purchased) &&
          (char6Unlocked || char6Purchased) &&
          (char7Unlocked || char7Purchased) &&
          (char8Unlocked || char8Purchased) &&
          (char9Unlocked || char9Purchased) &&
          (char10Unlocked || char10Purchased) &&
          (char11Unlocked || char11Purchased) &&
          (char12Unlocked || char12Purchased) &&
          (char13Unlocked || char13Purchased) &&
          (char14Unlocked || char14Purchased) &&
          (char15Unlocked || char15Purchased) &&
          (char16Unlocked || char16Purchased) &&
          (char17Unlocked || char17Purchased) &&
          (char18Unlocked || char18Purchased) &&
          (!char19Unlocked && !char19Purchased) &&
          !allCharsUnlocked)
        {
            nextChar = 19;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (!char20Unlocked && !char20Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 20;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (!char21Unlocked && !char21Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 21;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (!char22Unlocked && !char22Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 22;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (!char23Unlocked && !char23Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 23;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (!char24Unlocked && !char24Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 24;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (char24Unlocked || char24Purchased) &&
         (!char25Unlocked && !char25Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 25;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (char24Unlocked || char24Purchased) &&
         (char25Unlocked || char25Purchased) &&
         (!char26Unlocked && !char26Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 26;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (char24Unlocked || char24Purchased) &&
         (char25Unlocked || char25Purchased) &&
         (char26Unlocked || char26Purchased) &&
         (!char27Unlocked && !char27Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 27;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (char24Unlocked || char24Purchased) &&
         (char25Unlocked || char25Purchased) &&
         (char26Unlocked || char26Purchased) &&
         (char27Unlocked || char27Purchased) &&
         (!char28Unlocked && !char28Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 28;
            ES2.Save(nextChar, "nextChar");
        }
        if (
         (char1Unlocked || char1Purchased) &&
         (char2Unlocked || char2Purchased) &&
         (char3Unlocked || char3Purchased) &&
         (char4Unlocked || char4Purchased) &&
         (char5Unlocked || char5Purchased) &&
         (char6Unlocked || char6Purchased) &&
         (char7Unlocked || char7Purchased) &&
         (char8Unlocked || char8Purchased) &&
         (char9Unlocked || char9Purchased) &&
         (char10Unlocked || char10Purchased) &&
         (char11Unlocked || char11Purchased) &&
         (char12Unlocked || char12Purchased) &&
         (char13Unlocked || char13Purchased) &&
         (char14Unlocked || char14Purchased) &&
         (char15Unlocked || char15Purchased) &&
         (char16Unlocked || char16Purchased) &&
         (char17Unlocked || char17Purchased) &&
         (char18Unlocked || char18Purchased) &&
         (char19Unlocked || char19Purchased) &&
         (char20Unlocked || char20Purchased) &&
         (char21Unlocked || char21Purchased) &&
         (char22Unlocked || char22Purchased) &&
         (char23Unlocked || char23Purchased) &&
         (char24Unlocked || char24Purchased) &&
         (char25Unlocked || char25Purchased) &&
         (char26Unlocked || char26Purchased) &&
         (char27Unlocked || char27Purchased) &&
         (char28Unlocked || char28Purchased) &&
         (!char29Unlocked && !char29Purchased) &&
         !allCharsUnlocked)
        {
            nextChar = 29;
            ES2.Save(nextChar, "nextChar");
        }
       





    }

    void Start()
		{
        findButtonsScript.FindInActive();
       // RestorePurchases();

        if (ES2.Exists ("char1Unlock")) {

			char1Unlocked = ES2.Load<bool> ("char1Unlock");
		}

		if (ES2.Exists ("char2Unlock")) {

			char2Unlocked = ES2.Load<bool> ("char2Unlock");
		}

		if (ES2.Exists ("char3Unlock")) {

			char3Unlocked = ES2.Load<bool> ("char3Unlock");
		}

		if (ES2.Exists ("char4Unlock")) {

			char4Unlocked = ES2.Load<bool> ("char4Unlock");
		}

		if (ES2.Exists ("char5Unlock")) {

			char5Unlocked = ES2.Load<bool> ("char5Unlock");

		}

		if (ES2.Exists ("char6Unlock")) {

			char6Unlocked = ES2.Load<bool> ("char6Unlock");
		}

		if (ES2.Exists ("char7Unlock")) {

			char7Unlocked = ES2.Load<bool> ("char7Unlock");

		}

		if (ES2.Exists ("char8Unlock")) {

			char8Unlocked = ES2.Load<bool> ("char8Unlock");

		}

        if (ES2.Exists("char9Unlock"))
        {

            char9Unlocked = ES2.Load<bool>("char9Unlock");
        }

        if (ES2.Exists("char10Unlock"))
        {

            char10Unlocked = ES2.Load<bool>("char10Unlock");
        }

        if (ES2.Exists("char11Unlock"))
        {

            char11Unlocked = ES2.Load<bool>("char11Unlock");
        }

        if (ES2.Exists("char12Unlock"))
        {

            char12Unlocked = ES2.Load<bool>("char12Unlock");
        }

        if (ES2.Exists("char13Unlock"))
        {

            char13Unlocked = ES2.Load<bool>("char13Unlock");

        }

        if (ES2.Exists("char14Unlock"))
        {

            char14Unlocked = ES2.Load<bool>("char14Unlock");
        }

        if (ES2.Exists("char15Unlock"))
        {

            char15Unlocked = ES2.Load<bool>("char15Unlock");

        }

        if (ES2.Exists("char16Unlock"))
        {

            char16Unlocked = ES2.Load<bool>("char16Unlock");

        }

        if (ES2.Exists("char17Unlock"))
        {

            char17Unlocked = ES2.Load<bool>("char17Unlock");
        }

        if (ES2.Exists("char18Unlock"))
        {

            char18Unlocked = ES2.Load<bool>("char18Unlock");
        }

        if (ES2.Exists("char19Unlock"))
        {

            char19Unlocked = ES2.Load<bool>("char19Unlock");

        }

        if (ES2.Exists("char20Unlock"))
        {

            char20Unlocked = ES2.Load<bool>("char20Unlock");
        }

        if (ES2.Exists("char21Unlock"))
        {

            char21Unlocked = ES2.Load<bool>("char21Unlock");

        }

        if (ES2.Exists("char22Unlock"))
        {

            char22Unlocked = ES2.Load<bool>("char22Unlock");

        }

        if (ES2.Exists("char23Unlock"))
        {

            char23Unlocked = ES2.Load<bool>("char23Unlock");
        }

        if (ES2.Exists("char24Unlock"))
        {

            char24Unlocked = ES2.Load<bool>("char24Unlock");
        }

        if (ES2.Exists("char25Unlock"))
        {

            char25Unlocked = ES2.Load<bool>("char25Unlock");
        }

        if (ES2.Exists("char26Unlock"))
        {

            char26Unlocked = ES2.Load<bool>("char26Unlock");
        }

        if (ES2.Exists("char27Unlock"))
        {

            char27Unlocked = ES2.Load<bool>("char27Unlock");

        }

        if (ES2.Exists("char28Unlock"))
        {

            char28Unlocked = ES2.Load<bool>("char28Unlock");
        }

        if (ES2.Exists("char29Unlock"))
        {

            char29Unlocked = ES2.Load<bool>("char29Unlock");

        }

        

        if (ES2.Exists ("firstStart"))firstStart = ES2.Load<bool> ("firstStart");

			if(ES2.Exists("char1Purchased"))char1Purchased = ES2.Load<bool>("char1Purchased");
			if(ES2.Exists("char2Purchased"))char2Purchased = ES2.Load<bool>("char2Purchased");
			if(ES2.Exists("char3Purchased"))char3Purchased = ES2.Load<bool>("char3Purchased");
			if(ES2.Exists("char4Purchased"))char4Purchased = ES2.Load<bool>("char4Purchased");
			if(ES2.Exists("char5Purchased"))char5Purchased = ES2.Load<bool>("char5Purchased");
			if(ES2.Exists("char6Purchased"))char6Purchased = ES2.Load<bool>("char6Purchased");
			if(ES2.Exists("char7Purchased"))char7Purchased = ES2.Load<bool>("char7Purchased");
			if(ES2.Exists("char8Purchased"))char8Purchased = ES2.Load<bool>("char8Purchased");
            if(ES2.Exists("char9Purchased"))char9Purchased = ES2.Load<bool>("char9Purchased");
            if(ES2.Exists("char10Purchased"))char10Purchased = ES2.Load<bool>("char10Purchased");
            if(ES2.Exists("char11Purchased"))char11Purchased = ES2.Load<bool>("char11Purchased");
            if(ES2.Exists("char12Purchased"))char12Purchased = ES2.Load<bool>("char12Purchased");
            if(ES2.Exists("char13Purchased"))char13Purchased = ES2.Load<bool>("char13Purchased");
            if(ES2.Exists("char14Purchased"))char14Purchased = ES2.Load<bool>("char14Purchased");
            if(ES2.Exists("char15Purchased"))char15Purchased = ES2.Load<bool>("char15Purchased");
            if(ES2.Exists("char16Purchased"))char16Purchased = ES2.Load<bool>("char16Purchased");
            if(ES2.Exists("char17Purchased"))char17Purchased = ES2.Load<bool>("char17Purchased");
            if(ES2.Exists("char18Purchased"))char18Purchased = ES2.Load<bool>("char18Purchased");
            if(ES2.Exists("char19Purchased"))char19Purchased = ES2.Load<bool>("char19Purchased");
            if(ES2.Exists("char20Purchased"))char20Purchased = ES2.Load<bool>("char20Purchased");
            if(ES2.Exists("char21Purchased"))char21Purchased = ES2.Load<bool>("char21Purchased");
            if(ES2.Exists("char22Purchased"))char22Purchased = ES2.Load<bool>("char22Purchased");
            if(ES2.Exists("char23Purchased"))char23Purchased = ES2.Load<bool>("char23Purchased");
            if(ES2.Exists("char24Purchased"))char24Purchased = ES2.Load<bool>("char24Purchased");
            if(ES2.Exists("char25Purchased"))char25Purchased = ES2.Load<bool>("char25Purchased");
            if(ES2.Exists("char26Purchased"))char26Purchased = ES2.Load<bool>("char26Purchased");
            if(ES2.Exists("char27Purchased"))char27Purchased = ES2.Load<bool>("char27Purchased");
            if(ES2.Exists("char28Purchased"))char28Purchased = ES2.Load<bool>("char28Purchased");
            if(ES2.Exists("char29Purchased"))char29Purchased = ES2.Load<bool>("char29Purchased");
            
        if (ES2.Exists("noAds"))noAdsPurchased = ES2.Load<bool> ("noAds");

			

			//cata1 = m_StoreController.products.WithID (kProductIDCharacter1);

			
				

			
					
			/*	foreach (Product prod in m_StoreController.products.all) {

					if (prod.hasReceipt) {

						if (prod.definition.id == "character1") {

							char1Purchased = true;
							ES2.Save (char1Purchased, "char1Purchased");
						}
						if (prod.definition.id == "character2") {

							char2Purchased = true;
							ES2.Save (char2Purchased, "char2Purchased");

						}
						if (prod.definition.id == "character3") {

							char3Purchased = true;
							ES2.Save (char3Purchased, "char3Purchased");
						}
						if (prod.definition.id == "character4") {

							char4Purchased = true;
							ES2.Save (char4Purchased, "char4Purchased");
						}
						if (prod.definition.id == "character5") {

							char5Purchased = true;
							ES2.Save (char5Purchased, "char5Purchased");
						}
						if (prod.definition.id == "character6") {

							char6Purchased = true;
							ES2.Save (char6Purchased, "char6Purchased");
						}
						if (prod.definition.id == "character7") {

							char7Purchased = true;
							ES2.Save (char7Purchased, "char7Purchased");

						}
						if (prod.definition.id == "character8") {

							char8Purchased = true;
							ES2.Save (char8Purchased, "char8Purchased");
						}
                    if (prod.definition.id == "character9")
                    {

                        char9Purchased = true;
                        ES2.Save(char9Purchased, "char9Purchased");
                    }
                    if (prod.definition.id == "character10")
                    {

                        char10Purchased = true;
                        ES2.Save(char10Purchased, "char10Purchased");

                    }
                    if (prod.definition.id == "character11")
                    {

                        char11Purchased = true;
                        ES2.Save(char11Purchased, "char11Purchased");
                    }
                    if (prod.definition.id == "character12")
                    {

                        char12Purchased = true;
                        ES2.Save(char12Purchased, "char12Purchased");
                    }
                    if (prod.definition.id == "character13")
                    {

                        char13Purchased = true;
                        ES2.Save(char13Purchased, "char13Purchased");
                    }
                    if (prod.definition.id == "character14")
                    {

                        char14Purchased = true;
                        ES2.Save(char14Purchased, "char14Purchased");
                    }
                    if (prod.definition.id == "character15")
                    {

                        char15Purchased = true;
                        ES2.Save(char15Purchased, "char15Purchased");

                    }
                    if (prod.definition.id == "character16")
                    {

                        char16Purchased = true;
                        ES2.Save(char16Purchased, "char16Purchased");
                    }
                    if (prod.definition.id == "character17")
                    {

                        char17Purchased = true;
                        ES2.Save(char17Purchased, "char17Purchased");
                    }
                    if (prod.definition.id == "character18")
                    {

                        char18Purchased = true;
                        ES2.Save(char18Purchased, "char18Purchased");

                    }
                    if (prod.definition.id == "character19")
                    {

                        char19Purchased = true;
                        ES2.Save(char19Purchased, "char19Purchased");
                    }
                    if (prod.definition.id == "character20")
                    {

                        char20Purchased = true;
                        ES2.Save(char20Purchased, "char20Purchased");
                    }
                    if (prod.definition.id == "character21")
                    {

                        char21Purchased = true;
                        ES2.Save(char21Purchased, "char21Purchased");
                    }
                    if (prod.definition.id == "character22")
                    {

                        char22Purchased = true;
                        ES2.Save(char22Purchased, "char22Purchased");
                    }
                    if (prod.definition.id == "character23")
                    {

                        char23Purchased = true;
                        ES2.Save(char23Purchased, "char23Purchased");

                    }
                    if (prod.definition.id == "character24")
                    {

                        char24Purchased = true;
                        ES2.Save(char24Purchased, "char24Purchased");
                    }
                    if (prod.definition.id == "character25")
                    {

                        char25Purchased = true;
                        ES2.Save(char25Purchased, "char25Purchased");
                    }
                    if (prod.definition.id == "character26")
                    {

                        char26Purchased = true;
                        ES2.Save(char26Purchased, "char26Purchased");

                    }
                    if (prod.definition.id == "character27")
                    {

                        char27Purchased = true;
                        ES2.Save(char27Purchased, "char27Purchased");
                    }
                    if (prod.definition.id == "character28")
                    {

                        char28Purchased = true;
                        ES2.Save(char28Purchased, "char28Purchased");
                    }
                    if (prod.definition.id == "character29")
                    {

                        char29Purchased = true;
                        ES2.Save(char29Purchased, "char29Purchased");
                    }
                    
                    
                    if (prod.definition.id == "noads") {

							noAdsPurchased = true;
							ES2.Save (noAdsPurchased, "noAds");
						}




					}

				}*/
			

				firstStart = false;
				ES2.Save(firstStart, "firstStart");

				

				if(ES2.Exists("myHighscore"))highscore = ES2.Load<int> ("myHighscore");

		if (char1Unlocked || char1Purchased) {

					char1button.SetActive (true);
					char1buttonD.SetActive (false);


				}
		if (char2Unlocked || char2Purchased) {

					char2button.SetActive (true);
					char2buttonD.SetActive (false);


				}

		if (char3Unlocked || char3Purchased) {

					char3button.SetActive (true);
					char3buttonD.SetActive (false);


				}

		if (char4Unlocked || char4Purchased) {

					char4button.SetActive (true);
					char4buttonD.SetActive (false);


				}

		if (char5Unlocked || char5Purchased) {

					char5button.SetActive (true);
					char5buttonD.SetActive (false);


				}
		if (char6Unlocked || char6Purchased) {

					char6button.SetActive (true);
					char6buttonD.SetActive (false);


				}
		if (char7Unlocked || char7Purchased) {

					char7button.SetActive (true);
					char7buttonD.SetActive (false);


				}
		if (char8Unlocked || char8Purchased) {

					char8button.SetActive (true);
					char8buttonD.SetActive (false);

				}
        if (char9Unlocked || char9Purchased)
        {

            char9button.SetActive(true);
            char9buttonD.SetActive(false);


        }
        if (char10Unlocked || char10Purchased)
        {

            char10button.SetActive(true);
            char10buttonD.SetActive(false);


        }

        if (char11Unlocked || char11Purchased)
        {

            char11button.SetActive(true);
            char11buttonD.SetActive(false);


        }

        if (char12Unlocked || char12Purchased)
        {

            char12button.SetActive(true);
            char12buttonD.SetActive(false);


        }

        if (char13Unlocked || char13Purchased)
        {

            char13button.SetActive(true);
            char13buttonD.SetActive(false);


        }
        if (char14Unlocked || char14Purchased)
        {

            char14button.SetActive(true);
            char14buttonD.SetActive(false);


        }
        if (char15Unlocked || char15Purchased)
        {

            char15button.SetActive(true);
            char15buttonD.SetActive(false);


        }
        if (char16Unlocked || char16Purchased)
        {

            char16button.SetActive(true);
            char16buttonD.SetActive(false);

        }
        if (char17Unlocked || char17Purchased)
        {

            char17button.SetActive(true);
            char17buttonD.SetActive(false);


        }
        if (char18Unlocked || char18Purchased)
        {

            char18button.SetActive(true);
            char18buttonD.SetActive(false);


        }

        if (char19Unlocked || char19Purchased)
        {

            char19button.SetActive(true);
            char19buttonD.SetActive(false);


        }

        if (char20Unlocked || char20Purchased)
        {

            char20button.SetActive(true);
            char20buttonD.SetActive(false);


        }

        if (char21Unlocked || char21Purchased)
        {

            char21button.SetActive(true);
            char21buttonD.SetActive(false);


        }
        if (char22Unlocked || char22Purchased)
        {

            char22button.SetActive(true);
            char22buttonD.SetActive(false);


        }
        if (char23Unlocked || char23Purchased)
        {

            char23button.SetActive(true);
            char23buttonD.SetActive(false);


        }
        if (char24Unlocked || char24Purchased)
        {

            char24button.SetActive(true);
            char24buttonD.SetActive(false);

        }
        if (char25Unlocked || char25Purchased)
        {

            char25button.SetActive(true);
            char25buttonD.SetActive(false);


        }
        if (char26Unlocked || char26Purchased)
        {

            char26button.SetActive(true);
            char26buttonD.SetActive(false);


        }

        if (char27Unlocked || char27Purchased)
        {

            char27button.SetActive(true);
            char27buttonD.SetActive(false);


        }

        if (char28Unlocked || char28Purchased)
        {

            char28button.SetActive(true);
            char28buttonD.SetActive(false);


        }

        if (char29Unlocked || char29Purchased)
        {

            char29button.SetActive(true);
            char29buttonD.SetActive(false);


        }
        
        // If we haven't set up the Unity Purchasing reference
        if (m_StoreController == null)
				{
					// Begin to configure our connection to Purchasing
					InitializePurchasing();
				}
			}

		public void InitializePurchasing() 
		{
			// If we have already connected to Purchasing ...
			if (IsInitialized())
			{
				// ... we are done here.
				return;
			}

			// Create a builder, first passing in a suite of Unity provided stores.
			var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

			// Add a product to sell / restore by way of its identifier, associating the general identifier
			// with its store-specific identifiers.
			builder.AddProduct(kProductIDConsumable, ProductType.Consumable);
			// Continue adding the non-consumable product.
			builder.AddProduct(kProductIDCharacter1, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter2, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter3, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter4, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter5, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter6, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter7, ProductType.NonConsumable);
			builder.AddProduct(kProductIDCharacter8, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter9, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter10, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter11, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter12, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter13, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter14, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter15, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter16, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter17, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter18, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter19, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter20, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter21, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter22, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter23, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter24, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter25, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter26, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter27, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter28, ProductType.NonConsumable);
            builder.AddProduct(kProductIDCharacter29, ProductType.NonConsumable);
           



        // And finish adding the subscription product. Notice this uses store-specific IDs, illustrating
        // if the Product ID was configured differently between Apple and Google stores. Also note that
        // one uses the general kProductIDSubscription handle inside the game - the store-specific IDs 
        // must only be referenced here. 
        builder.AddProduct(kProductIDSubscription, ProductType.Subscription, new IDs(){
				{ kProductNameAppleSubscription, AppleAppStore.Name },
				{ kProductNameGooglePlaySubscription, GooglePlay.Name },
			});

			// Kick off the remainder of the set-up with an asynchrounous call, passing the configuration 
			// and this class' instance. Expect a response either in OnInitialized or OnInitializeFailed.
			UnityPurchasing.Initialize(this, builder);
		}


		private bool IsInitialized()
		{
			// Only say we are initialized if both the Purchasing references are set.
			return m_StoreController != null && m_StoreExtensionProvider != null;
		}


		public void BuyConsumable()
		{
			// Buy the consumable product using its general identifier. Expect a response either 
			// through ProcessPurchase or OnPurchaseFailed asynchronously.
			BuyProductID(kProductIDConsumable);
		}


		public void BuyNonConsumable()
		{
			// Buy the non-consumable product using its general identifier. Expect a response either 
			// through ProcessPurchase or OnPurchaseFailed asynchronously.
			if(thisChar == 1)BuyProductID(kProductIDCharacter1);
			if(thisChar == 2)BuyProductID(kProductIDCharacter2);
			if(thisChar == 3)BuyProductID(kProductIDCharacter3);
			if(thisChar == 4)BuyProductID(kProductIDCharacter4);
			if(thisChar == 5)BuyProductID(kProductIDCharacter5);
			if(thisChar == 6)BuyProductID(kProductIDCharacter6);
			if(thisChar == 7)BuyProductID(kProductIDCharacter7);
			if(thisChar == 8)BuyProductID(kProductIDCharacter8);
            if (thisChar == 9) BuyProductID(kProductIDCharacter9);
            if (thisChar == 10) BuyProductID(kProductIDCharacter10);
            if (thisChar == 11) BuyProductID(kProductIDCharacter11);
            if (thisChar == 12) BuyProductID(kProductIDCharacter12);
            if (thisChar == 13) BuyProductID(kProductIDCharacter13);
            if (thisChar == 14) BuyProductID(kProductIDCharacter14);
            if (thisChar == 15) BuyProductID(kProductIDCharacter15);
            if (thisChar == 16) BuyProductID(kProductIDCharacter16);
            if (thisChar == 17) BuyProductID(kProductIDCharacter17);
            if (thisChar == 18) BuyProductID(kProductIDCharacter18);
            if (thisChar == 19) BuyProductID(kProductIDCharacter19);
            if (thisChar == 20) BuyProductID(kProductIDCharacter20);
            if (thisChar == 21) BuyProductID(kProductIDCharacter21);
            if (thisChar == 22) BuyProductID(kProductIDCharacter22);
            if (thisChar == 23) BuyProductID(kProductIDCharacter23);
            if (thisChar == 24) BuyProductID(kProductIDCharacter24);
            if (thisChar == 25) BuyProductID(kProductIDCharacter25);
            if (thisChar == 26) BuyProductID(kProductIDCharacter26);
            if (thisChar == 27) BuyProductID(kProductIDCharacter27);
            if (thisChar == 28) BuyProductID(kProductIDCharacter28);
            if (thisChar == 29) BuyProductID(kProductIDCharacter29);
            



    }


		public void BuySubscription()
		{
			// Buy the subscription product using its the general identifier. Expect a response either 
			// through ProcessPurchase or OnPurchaseFailed asynchronously.
			// Notice how we use the general product identifier in spite of this ID being mapped to
			// custom store-specific identifiers above.
			BuyProductID(kProductIDSubscription);
		}


		void BuyProductID(string productId)
		{
			// If Purchasing has been initialized ...
			if (IsInitialized())
			{
				// ... look up the Product reference with the general product identifier and the Purchasing 
				// system's products collection.
				Product product = m_StoreController.products.WithID(productId);

				// If the look up found a product for this device's store and that product is ready to be sold ... 
				if (product != null && product.availableToPurchase)
				{
					Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
					// ... buy the product. Expect a response either through ProcessPurchase or OnPurchaseFailed 
					// asynchronously.
					m_StoreController.InitiatePurchase(product);
				}
				// Otherwise ...
				else
				{
					// ... report the product look-up failure situation  
					Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
				}
			}
			// Otherwise ...
			else
			{
				// ... report the fact Purchasing has not succeeded initializing yet. Consider waiting longer or 
				// retrying initiailization.
				Debug.Log("BuyProductID FAIL. Not initialized.");
			}
		}


		// Restore purchases previously made by this customer. Some platforms automatically restore purchases, like Google. 
		// Apple currently requires explicit purchase restoration for IAP, conditionally displaying a password prompt.
		public void RestorePurchases()
		{
			// If Purchasing has not yet been set up ...
			if (!IsInitialized())
			{
				// ... report the situation and stop restoring. Consider either waiting longer, or retrying initialization.
				Debug.Log("RestorePurchases FAIL. Not initialized.");
				return;
			}

			// If we are running on an Apple device ... 
			if (Application.platform == RuntimePlatform.IPhonePlayer || 
				Application.platform == RuntimePlatform.OSXPlayer)
			{
				// ... begin restoring purchases
				Debug.Log("RestorePurchases started ...");

				// Fetch the Apple store-specific subsystem.
				var apple = m_StoreExtensionProvider.GetExtension<IAppleExtensions>();
				// Begin the asynchronous process of restoring purchases. Expect a confirmation response in 
				// the Action<bool> below, and ProcessPurchase if there are previously purchased products to restore.
				apple.RestoreTransactions((result) => {

					foreach (Product prod in m_StoreController.products.all) {

						if (prod.hasReceipt) {

							if (prod.definition.id == "character1") {

								char1Purchased = true;
								ES2.Save (char1Purchased, "char1Purchased");
							}
							if (prod.definition.id == "character2") {

								char2Purchased = true;
								ES2.Save (char2Purchased, "char2Purchased");

							}
							if (prod.definition.id == "character3") {

								char3Purchased = true;
								ES2.Save (char3Purchased, "char3Purchased");
							}
							if (prod.definition.id == "character4") {

								char4Purchased = true;
								ES2.Save (char4Purchased, "char4Purchased");
							}
							if (prod.definition.id == "character5") {

								char5Purchased = true;
								ES2.Save (char5Purchased, "char5Purchased");
							}
							if (prod.definition.id == "character6") {

								char6Purchased = true;
								ES2.Save (char6Purchased, "char6Purchased");
							}
							if (prod.definition.id == "character7") {

								char7Purchased = true;
								ES2.Save (char7Purchased, "char7Purchased");

							}
							if (prod.definition.id == "character8") {

								char8Purchased = true;
								ES2.Save (char8Purchased, "char8Purchased");
							}
                            if (prod.definition.id == "character9")
                            {

                                char9Purchased = true;
                                ES2.Save(char9Purchased, "char9Purchased");
                            }
                            if (prod.definition.id == "character10")
                            {

                                char10Purchased = true;
                                ES2.Save(char10Purchased, "char10Purchased");

                            }
                            if (prod.definition.id == "character11")
                            {

                                char11Purchased = true;
                                ES2.Save(char11Purchased, "char11Purchased");
                            }
                            if (prod.definition.id == "character12")
                            {

                                char12Purchased = true;
                                ES2.Save(char12Purchased, "char12Purchased");
                            }
                            if (prod.definition.id == "character13")
                            {

                                char13Purchased = true;
                                ES2.Save(char13Purchased, "char13Purchased");
                            }
                            if (prod.definition.id == "character14")
                            {

                                char14Purchased = true;
                                ES2.Save(char14Purchased, "char14Purchased");
                            }
                            if (prod.definition.id == "character15")
                            {

                                char15Purchased = true;
                                ES2.Save(char15Purchased, "char15Purchased");

                            }
                            if (prod.definition.id == "character16")
                            {

                                char16Purchased = true;
                                ES2.Save(char16Purchased, "char16Purchased");
                            }
                            if (prod.definition.id == "character17")
                            {

                                char17Purchased = true;
                                ES2.Save(char17Purchased, "char17Purchased");
                            }
                            if (prod.definition.id == "character18")
                            {

                                char18Purchased = true;
                                ES2.Save(char18Purchased, "char18Purchased");

                            }
                            if (prod.definition.id == "character19")
                            {

                                char19Purchased = true;
                                ES2.Save(char19Purchased, "char19Purchased");
                            }
                            if (prod.definition.id == "character20")
                            {

                                char20Purchased = true;
                                ES2.Save(char20Purchased, "char20Purchased");
                            }
                            if (prod.definition.id == "character21")
                            {

                                char21Purchased = true;
                                ES2.Save(char21Purchased, "char21Purchased");
                            }
                            if (prod.definition.id == "character22")
                            {

                                char22Purchased = true;
                                ES2.Save(char22Purchased, "char22Purchased");
                            }
                            if (prod.definition.id == "character23")
                            {

                                char23Purchased = true;
                                ES2.Save(char23Purchased, "char23Purchased");

                            }
                            if (prod.definition.id == "character24")
                            {

                                char24Purchased = true;
                                ES2.Save(char24Purchased, "char24Purchased");
                            }
                            if (prod.definition.id == "character25")
                            {

                                char25Purchased = true;
                                ES2.Save(char25Purchased, "char25Purchased");
                            }
                            if (prod.definition.id == "character26")
                            {

                                char26Purchased = true;
                                ES2.Save(char26Purchased, "char26Purchased");

                            }
                            if (prod.definition.id == "character27")
                            {

                                char27Purchased = true;
                                ES2.Save(char27Purchased, "char27Purchased");
                            }
                            if (prod.definition.id == "character28")
                            {

                                char28Purchased = true;
                                ES2.Save(char28Purchased, "char28Purchased");
                            }
                            if (prod.definition.id == "character29")
                            {

                                char29Purchased = true;
                                ES2.Save(char29Purchased, "char29Purchased");
                            }
                            if (prod.definition.id == "noads") {

								noAdsPurchased = true;
								ES2.Save (noAdsPurchased, "noAds");
							}



						}

					}



					// The first phase of restoration. If no more responses are received on ProcessPurchase then 
					// no purchases are available to be restored.
					Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
				});
			}
			// Otherwise ...
			else
			{
				// We are not running on an Apple device. No work is necessary to restore purchases.
				Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
			}
		}


		//  
		// --- IStoreListener
		//

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
			// Purchasing has succeeded initializing. Collect our Purchasing references.
			Debug.Log("OnInitialized: PASS");

			// Overall Purchasing system, configured with products for this application.
			m_StoreController = controller;
			// Store specific subsystem, for accessing device-specific store features.
			m_StoreExtensionProvider = extensions;

        
    }


		public void OnInitializeFailed(InitializationFailureReason error)
		{
			// Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
			Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
		}


		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) 
		{
		findButtonsScript.FindInActive ();
			// A consumable product has been purchased by this user.
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDConsumable, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// The consumable item has been successfully purchased, add 100 coins to the player's in-game score.
				//ScoreManager.score += 100;
			}
			// Or ... a non-consumable product has been purchased by this user.
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter1, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char1button.SetActive (true);



				char1buttonD.SetActive (false);



				char1Purchased = true;
				ES2.Save (char1Purchased, "char1Purchased");

				/*
				if (thisChar == 0) {



				} else if (thisChar == 1) {
				
					char1button.SetActive (true);
					char1buttonD.SetActive (false);
					char1Purchased = true;
					ES2.Save (char1Purchased, "char1Purchased");
				
				}else if (thisChar == 2) {

					char2button.SetActive (true);
					char2buttonD.SetActive (false);
					char2Purchased = true;
					ES2.Save (char2Purchased, "char2Purchased");

				}
				else if (thisChar == 3) {

					char3button.SetActive (true);
					char3buttonD.SetActive (false);
					char3Purchased = true;
					ES2.Save (char3Purchased, "char3Purchased");

				}
				else if (thisChar == 4) {

					char4button.SetActive (true);
					char4buttonD.SetActive (false);
					char4Purchased = true;
					ES2.Save (char4Purchased, "char4Purchased");

				}
				else if (thisChar == 5) {

					char5button.SetActive (true);
					char5buttonD.SetActive (false);
					char5Purchased = true;
					ES2.Save (char5Purchased, "char5Purchased");

				}else if (thisChar == 6) {

					char6button.SetActive (true);
					char6buttonD.SetActive (false);
					char6Purchased = true;
					ES2.Save (char6Purchased, "char6Purchased");

				}else if (thisChar == 7) {

					char7button.SetActive (true);
					char7buttonD.SetActive (false);
					char7Purchased = true;
					ES2.Save (char7Purchased, "char7Purchased");

				}else if (thisChar == 8) {
					
					char8button.SetActive (true);
					char8buttonD.SetActive (false);
					char8Purchased = true;
					ES2.Save (char8Purchased, "char8Purchased");

				}*/

			} 
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter2, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char2button.SetActive (true);
				char2buttonD.SetActive (false);



				char2Purchased = true;
				ES2.Save (char2Purchased, "char2Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter3, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char3button.SetActive (true);
				char3buttonD.SetActive (false);




				char3Purchased = true;
				ES2.Save (char3Purchased, "char3Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter4, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char4button.SetActive (true);
				char4buttonD.SetActive (false);

		

				char4Purchased = true;
				ES2.Save (char4Purchased, "char4Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter5, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char5button.SetActive (true);
				char5buttonD.SetActive (false);




				char5Purchased = true;
				ES2.Save (char5Purchased, "char5Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter6, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char6button.SetActive (true);
				char6buttonD.SetActive (false);




				char6Purchased = true;
				ES2.Save (char6Purchased, "char6Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter7, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char7button.SetActive (true);
				char7buttonD.SetActive (false);


		


				char7Purchased = true;
				ES2.Save (char7Purchased, "char7Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter8, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char8button.SetActive (true);
				char8buttonD.SetActive (false);



				char8Purchased = true;
				ES2.Save (char8Purchased, "char8Purchased");

			}if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter9, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char9button.SetActive (true);
				char9buttonD.SetActive (false);



				char9Purchased = true;
				ES2.Save (char9Purchased, "char9Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter10, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char10button.SetActive (true);
            char10buttonD.SetActive (false);




            char10Purchased = true;
				ES2.Save (char10Purchased, "char10Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter11, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char11button.SetActive (true);
				char11buttonD.SetActive (false);

		

				char11Purchased = true;
				ES2.Save (char11Purchased, "char11Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter12, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char12button.SetActive (true);
				char12buttonD.SetActive (false);




				char12Purchased = true;
				ES2.Save (char12Purchased, "char12Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter13, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char13button.SetActive (true);
				char13buttonD.SetActive (false);




				char13Purchased = true;
				ES2.Save (char13Purchased, "char13Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter14, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char14button.SetActive (true);
				char14buttonD.SetActive (false);


		


				char14Purchased = true;
				ES2.Save (char14Purchased, "char14Purchased");

			}
			if (String.Equals (args.purchasedProduct.definition.id, kProductIDCharacter15, StringComparison.Ordinal)) {
				Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

				//popup.SetActive (false);


				char15button.SetActive (true);
				char15buttonD.SetActive (false);



				char15Purchased = true;
				ES2.Save (char15Purchased, "char15Purchased");

			}
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter16, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char16button.SetActive(true);
            char16buttonD.SetActive(false);



            char16Purchased = true;
            ES2.Save(char16Purchased, "char16Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter17, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char17button.SetActive(true);
            char17buttonD.SetActive(false);




            char17Purchased = true;
            ES2.Save(char17Purchased, "char17Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter18, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char18button.SetActive(true);
            char18buttonD.SetActive(false);



            char18Purchased = true;
            ES2.Save(char18Purchased, "char18Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter19, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char19button.SetActive(true);
            char19buttonD.SetActive(false);




            char19Purchased = true;
            ES2.Save(char19Purchased, "char19Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter20, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char20button.SetActive(true);
            char20buttonD.SetActive(false);




            char20Purchased = true;
            ES2.Save(char20Purchased, "char20Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter21, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char21button.SetActive(true);
            char21buttonD.SetActive(false);





            char21Purchased = true;
            ES2.Save(char21Purchased, "char21Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter22, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char22button.SetActive(true);
            char22buttonD.SetActive(false);



            char22Purchased = true;
            ES2.Save(char22Purchased, "char22Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter23, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char23button.SetActive(true);
            char23buttonD.SetActive(false);



            char23Purchased = true;
            ES2.Save(char23Purchased, "char23Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter24, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char24button.SetActive(true);
            char24buttonD.SetActive(false);




            char24Purchased = true;
            ES2.Save(char24Purchased, "char24Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter25, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char25button.SetActive(true);
            char25buttonD.SetActive(false);



            char25Purchased = true;
            ES2.Save(char25Purchased, "char25Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter26, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char26button.SetActive(true);
            char26buttonD.SetActive(false);




            char26Purchased = true;
            ES2.Save(char26Purchased, "char26Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter27, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char27button.SetActive(true);
            char27buttonD.SetActive(false);




            char27Purchased = true;
            ES2.Save(char27Purchased, "char27Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter28, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char28button.SetActive(true);
            char28buttonD.SetActive(false);





            char28Purchased = true;
            ES2.Save(char28Purchased, "char28Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter29, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);


            char29button.SetActive(true);
            char29buttonD.SetActive(false);



            char29Purchased = true;
            ES2.Save(char29Purchased, "char29Purchased");

        }
        


        // Or ... a subscription product has been purchased by this user.
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDSubscription, StringComparison.Ordinal))
			{
				Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
				// TODO: The subscription item has been successfully purchased, grant this to the player.
			}
			// Or ... an unknown product has been purchased by this user. Fill in additional products here....
			/*else 
			{
				Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
			}*/

			// Return a flag indicating whether this product has completely been received, or if the application needs 
			// to be reminded of this purchase at next app launch. Use PurchaseProcessingResult.Pending when still 
			// saving purchased products to the cloud, and when that save is delayed. 
			return PurchaseProcessingResult.Complete;
		}


		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
			// A product purchase attempt did not succeed. Check failureReason for more detail. Consider sharing 
			// this reason with the user to guide their troubleshooting actions.
			Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
		}
	}
//}