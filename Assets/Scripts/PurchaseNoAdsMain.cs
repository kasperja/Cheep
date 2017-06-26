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
public class PurchaseNoAdsMain : MonoBehaviour, IStoreListener
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

	public static string kProductIDNoAds = "noads";


	public static string kProductIDSubscription =  "subscription"; 

	// Apple App Store-specific product identifier for the subscription product.
	private static string kProductNameAppleSubscription =  "com.unity3d.subscription.new";

	// Google Play Store-specific product identifier subscription product.
	private static string kProductNameGooglePlaySubscription =  "com.unity3d.subscription.original";


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

    //public GameOverScript goScript;

    private bool firstStart = true;

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

    public bool noAdsPurchased = false;

	public Product cata1;






	private void Awake(){

		if(ES2.Exists("noAds"))noAdsPurchased = ES2.Load<bool> ("noAds");
        if (ES2.Exists("char1Purchased")) char1Purchased = ES2.Load<bool>("char1Purchased");
        if (ES2.Exists("char2Purchased")) char2Purchased = ES2.Load<bool>("char2Purchased");
        if (ES2.Exists("char3Purchased")) char3Purchased = ES2.Load<bool>("char3Purchased");
        if (ES2.Exists("char4Purchased")) char4Purchased = ES2.Load<bool>("char4Purchased");
        if (ES2.Exists("char5Purchased")) char5Purchased = ES2.Load<bool>("char5Purchased");
        if (ES2.Exists("char6Purchased")) char6Purchased = ES2.Load<bool>("char6Purchased");
        if (ES2.Exists("char7Purchased")) char7Purchased = ES2.Load<bool>("char7Purchased");
        if (ES2.Exists("char8Purchased")) char8Purchased = ES2.Load<bool>("char8Purchased");
    }

	void Update(){

		//if(ES2.Exists("noAds"))noAdsPurchased = ES2.Load<bool> ("noAds");

		if (noAdsPurchased) {

			gameObject.SetActive (false);

		}

        if (ES2.Exists("noAds")) noAdsPurchased = ES2.Load<bool>("noAds");


    }

	void Start()
	{
        RestorePurchases();
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

		//if (firstStart)
			RestorePurchases ();

		//if(firstStart){

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

			//}
		}

		firstStart = false;
		ES2.Save(firstStart, "firstStart");


		if(ES2.Exists("noAds"))noAdsPurchased = ES2.Load<bool> ("noAds");












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
		builder.AddProduct(kProductIDNoAds, ProductType.NonConsumable);

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

		BuyProductID(kProductIDNoAds);
		// Buy the non-consumable product using its general identifier. Expect a response either 
		// through ProcessPurchase or OnPurchaseFailed asynchronously.

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

		// A consumable product has been purchased by this user.
		if (String.Equals (args.purchasedProduct.definition.id, kProductIDConsumable, StringComparison.Ordinal)) {
			Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			// The consumable item has been successfully purchased, add 100 coins to the player's in-game score.
			//ScoreManager.score += 100;
		}
		// Or ... a non-consumable product has been purchased by this user.
		if (String.Equals (args.purchasedProduct.definition.id, kProductIDNoAds, StringComparison.Ordinal)) {
			Debug.Log (string.Format ("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
			// TODO: The non-consumable item has been successfully purchased, grant this item to the player.

			noAdsPurchased = true;

			ES2.Save (noAdsPurchased, "noAds");
			//popup.SetActive (false);
			//if(noAdsPurchased)gameObject.SetActive (false);

		}

        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter1, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            



            char1Purchased = true;
            ES2.Save(char1Purchased, "char1Purchased");

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
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter2, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char2Purchased = true;
            ES2.Save(char2Purchased, "char2Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter3, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char3Purchased = true;
            ES2.Save(char3Purchased, "char3Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter4, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char4Purchased = true;
            ES2.Save(char4Purchased, "char4Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter5, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            


            char5Purchased = true;
            ES2.Save(char5Purchased, "char5Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter6, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char6Purchased = true;
            ES2.Save(char6Purchased, "char6Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter7, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            



            char7Purchased = true;
            ES2.Save(char7Purchased, "char7Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter8, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            
            char8Purchased = true;
            ES2.Save(char8Purchased, "char8Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter9, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            
            char9Purchased = true;
            ES2.Save(char9Purchased, "char9Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter10, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char10Purchased = true;
            ES2.Save(char10Purchased, "char10Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter11, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);
            

            char11Purchased = true;
            ES2.Save(char11Purchased, "char11Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter12, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char12Purchased = true;
            ES2.Save(char12Purchased, "char12Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter13, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            


            char13Purchased = true;
            ES2.Save(char13Purchased, "char13Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter14, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);
            

            char14Purchased = true;
            ES2.Save(char14Purchased, "char14Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter15, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char15Purchased = true;
            ES2.Save(char15Purchased, "char15Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter16, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char16Purchased = true;
            ES2.Save(char16Purchased, "char16Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter17, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            


            char17Purchased = true;
            ES2.Save(char17Purchased, "char17Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter18, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);
            

            char18Purchased = true;
            ES2.Save(char18Purchased, "char18Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter19, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char19Purchased = true;
            ES2.Save(char19Purchased, "char19Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter20, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char20Purchased = true;
            ES2.Save(char20Purchased, "char20Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter21, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char21Purchased = true;
            ES2.Save(char21Purchased, "char21Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter22, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);
            


            char22Purchased = true;
            ES2.Save(char22Purchased, "char22Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter23, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char23Purchased = true;
            ES2.Save(char23Purchased, "char23Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter24, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            


            char24Purchased = true;
            ES2.Save(char24Purchased, "char24Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter25, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char25Purchased = true;
            ES2.Save(char25Purchased, "char25Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter26, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char26Purchased = true;
            ES2.Save(char26Purchased, "char26Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter27, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            

            char27Purchased = true;
            ES2.Save(char27Purchased, "char27Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter28, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            



            char28Purchased = true;
            ES2.Save(char28Purchased, "char28Purchased");

        }
        if (String.Equals(args.purchasedProduct.definition.id, kProductIDCharacter29, StringComparison.Ordinal))
        {
            Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));
            // TODO: The non-consumable item has been successfully purchased, grant this item to the player.

            //popup.SetActive (false);

            


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