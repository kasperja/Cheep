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
		//public GameObject char9buttonD;
		public GameObject popup;

		public int thisChar = 0;

		public int highscore = 0;

		public int score1 = 5000;
		public int score2 = 10000;
		public int score3 = 15000;
		public int score4 = 20000;
		public int score5 = 25000;
		public int score6 = 30000;
		public int score7 = 35000;
		public int score8 = 40000;

		public Product cata1;

		public bool char1Purchased = false;
		public bool char2Purchased = false;
		public bool char3Purchased = false;
		public bool char4Purchased = false;
		public bool char5Purchased = false;
		public bool char6Purchased = false;
		public bool char7Purchased = false;
		public bool char8Purchased = false;

		private bool firstStart = true;

	public FindButtons findButtonsScript;

	public bool noAdsPurchased = false;

		private void Awake(){
		
		if(ES2.Exists("myHighscore"))highscore = ES2.Load<int> ("myHighscore");
		findButtonsScript.FindInActive ();
		//Instance = this;

		}

		void Update(){
		if (highscore >= score1 || char1Purchased) {

			char1button.SetActive (true);
			char1buttonD.SetActive (false);


		}
		if (highscore >= score2 || char2Purchased) {

			char2button.SetActive (true);
			char2buttonD.SetActive (false);


		}

		if (highscore >= score3 || char3Purchased) {

			char3button.SetActive (true);
			char3buttonD.SetActive (false);


		}

		if (highscore >= score4 || char4Purchased) {

			char4button.SetActive (true);
			char4buttonD.SetActive (false);


		}

		if (highscore >= score5 || char5Purchased) {

			char5button.SetActive (true);
			char5buttonD.SetActive (false);


		}
		if (highscore >= score6 || char6Purchased) {

			char6button.SetActive (true);
			char6buttonD.SetActive (false);


		}
		if (highscore >= score7 || char7Purchased) {

			char7button.SetActive (true);
			char7buttonD.SetActive (false);


		}
		if (highscore >= score8 || char8Purchased) {

			char8button.SetActive (true);
			char8buttonD.SetActive (false);

		}

		

		
		}

		void Start()
		{
		

			if (ES2.Exists ("firstStart"))firstStart = ES2.Load<bool> ("firstStart");

			if(ES2.Exists("char1Purchased"))char1Purchased = ES2.Load<bool> ("char1Purchased");
			if(ES2.Exists("char2Purchased"))char2Purchased = ES2.Load<bool> ("char2Purchased");
			if(ES2.Exists("char3Purchased"))char3Purchased = ES2.Load<bool> ("char3Purchased");
			if(ES2.Exists("char4Purchased"))char4Purchased = ES2.Load<bool> ("char4Purchased");
			if(ES2.Exists("char5Purchased"))char5Purchased = ES2.Load<bool> ("char5Purchased");
			if(ES2.Exists("char6Purchased"))char6Purchased = ES2.Load<bool> ("char6Purchased");
			if(ES2.Exists("char7Purchased"))char7Purchased = ES2.Load<bool> ("char7Purchased");
			if(ES2.Exists("char8Purchased"))char8Purchased = ES2.Load<bool> ("char8Purchased");
			if(ES2.Exists("noAds"))noAdsPurchased = ES2.Load<bool> ("noAds");

			InitializePurchasing ();

			//cata1 = m_StoreController.products.WithID (kProductIDCharacter1);

			if (firstStart)
				RestorePurchases ();

			if(firstStart){
					
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
						if (prod.definition.id == "noAds") {

							noAdsPurchased = true;
							ES2.Save (noAdsPurchased, "noAds");
						}




					}

				}
			}

				firstStart = false;
				ES2.Save(firstStart, "firstStart");

				

				if(ES2.Exists("myHighscore"))highscore = ES2.Load<int> ("myHighscore");

				if (highscore >= score1 || char1Purchased) {

					char1button.SetActive (true);
					char1buttonD.SetActive (false);


				}
				if (highscore >= score2 || char2Purchased) {

					char2button.SetActive (true);
					char2buttonD.SetActive (false);


				}

				if (highscore >= score3 || char3Purchased) {

					char3button.SetActive (true);
					char3buttonD.SetActive (false);


				}

				if (highscore >= score4 || char4Purchased) {

					char4button.SetActive (true);
					char4buttonD.SetActive (false);


				}

				if (highscore >= score5 || char5Purchased) {

					char5button.SetActive (true);
					char5buttonD.SetActive (false);


				}
				if (highscore >= score6 || char6Purchased) {

					char6button.SetActive (true);
					char6buttonD.SetActive (false);


				}
				if (highscore >= score7 || char7Purchased) {

					char7button.SetActive (true);
					char7buttonD.SetActive (false);


				}
				if (highscore >= score8 || char8Purchased) {

					char8button.SetActive (true);
					char8buttonD.SetActive (false);

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

							if (prod.definition.id == "character.1") {

								char1Purchased = true;
								ES2.Save (char1Purchased, "char1Purchased");
							}
							if (prod.definition.id == "character.2") {

								char2Purchased = true;
								ES2.Save (char2Purchased, "char2Purchased");

							}
							if (prod.definition.id == "character.3") {

								char3Purchased = true;
								ES2.Save (char3Purchased, "char3Purchased");
							}
							if (prod.definition.id == "character.4") {

								char4Purchased = true;
								ES2.Save (char4Purchased, "char4Purchased");
							}
							if (prod.definition.id == "character.5") {

								char5Purchased = true;
								ES2.Save (char5Purchased, "char5Purchased");
							}
							if (prod.definition.id == "character.6") {

								char6Purchased = true;
								ES2.Save (char6Purchased, "char6Purchased");
							}
							if (prod.definition.id == "character.7") {

								char7Purchased = true;
								ES2.Save (char7Purchased, "char7Purchased");

							}
							if (prod.definition.id == "character.8") {

								char8Purchased = true;
								ES2.Save (char8Purchased, "char8Purchased");
							}
							if (prod.definition.id == "noAds") {

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