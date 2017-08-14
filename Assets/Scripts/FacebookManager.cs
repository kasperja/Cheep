using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Facebook.Unity;

public class FacebookManager : MonoBehaviour {

	private static FacebookManager _instance;

	public static FacebookManager Instance
	{

		get{ 
		
			if (_instance == null) {
			
				GameObject fbm = new GameObject ("FBManager");

				fbm.AddComponent<FacebookManager> ();
			
			}

			return _instance;
		
		}



	}

	public bool IsLoggedIn { get; set;}

	public string ProfileName { get; set;}

	public Sprite ProfilePic { get; set;}

	public string AppLinkURL{ get; set;}

	void Awake()
	{
	
		DontDestroyOnLoad (this.gameObject);

		_instance = this;

		IsLoggedIn = true;
	
	
	}

	public void InitFB()
	{
	
		if (!FB.IsInitialized) {

			FB.Init (SetInit, OnHideUnity);

		} else {

			IsLoggedIn = FB.IsLoggedIn;

		}
	
	}

	void SetInit()
	{

		if (FB.IsLoggedIn) {

			Debug.Log ("FB is logged in");

			GetProfile ();

		} else {

			Debug.Log ("FB is not logged in");

		}

		IsLoggedIn = FB.IsLoggedIn;


	}

	void OnHideUnity(bool isGameShown)
	{

		if (!isGameShown) {

			Time.timeScale = 0;

		} else {

			Time.timeScale = 1;

		}


	}

	public void GetProfile(){
	
		FB.API ("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
		FB.API ("/me/picture?type=square&height=64&width=64", HttpMethod.GET, DisplayProfilePic);
		FB.GetAppLink (DealWithAppLink);
	
	}

	void DisplayUsername(IResult result)
	{



		if (result.Error == null) {

			ProfileName = "" + result.ResultDictionary["first_name"];

		} else {

			Debug.Log (result.Error);

		}

	}

	void DisplayProfilePic(IGraphResult result)
	{

		if (result.Texture != null) {

			ProfilePic = Sprite.Create (result.Texture, new Rect(0,0,64,64), new Vector2());

		}

	}

	void DealWithAppLink(IAppLinkResult result){
	
		if (!string.IsNullOrEmpty (result.Url)) {
		
			AppLinkURL = result.Url;
			Debug.Log (AppLinkURL);
		
		} else {
		
			AppLinkURL = "https://snogame.com/";
		
		}
	
	
	}

	public void Share()

	{
		if (ES2.Exists ("myHighscore")) {
			
			FB.FeedShare (
		
				string.Empty, 
				new Uri (AppLinkURL),
				FacebookManager.Instance.ProfileName + " scored " + ES2.Load<int> ("myHighscore") + " in SNÖ!",
				"Try if you can beat it",
				"Play for free on iPhone or Android",
				new Uri ("http://i.imgur.com/IaZQqNx.jpg"),
				string.Empty,
				ShareCallback
		
			);
		} else {
		
			FB.FeedShare (

				string.Empty, 
				new Uri (AppLinkURL),
				FacebookManager.Instance.ProfileName + " plays SNÖ",
				"Check out the game and compete",
				"Play for free on iPhone or Android",
				new Uri ("http://i.imgur.com/IaZQqNx.jpg"),
				string.Empty,
				ShareCallback

			);
		
		}

	}

	void ShareCallback(IResult result){
	
		if (result.Cancelled) {
		
			Debug.Log ("Share cancelled");
		
		} else if (!string.IsNullOrEmpty (result.Error)) {
		
			Debug.Log ("Error on share");
		
		} else if (!string.IsNullOrEmpty (result.RawResult)) {
		
			Debug.Log ("succes on share");
		
		}
	
	}

	public void Invite()
	{
	
		FB.Mobile.AppInvite (

			new Uri(AppLinkURL),
			new Uri("http://i.imgur.com/IaZQqNx.jpg"),
			InviteCallback
		
		
		);
	
	}

	void InviteCallback(IResult result)
	{
	
		if (result.Cancelled) {

			Debug.Log ("Invite cancelled");

		} else if (!string.IsNullOrEmpty (result.Error)) {

			Debug.Log ("Error on invite");

		} else if (!string.IsNullOrEmpty (result.RawResult)) {

			Debug.Log ("succes on invite");

		}
	
	}

	public void ShareWithUsers(){


		if (ES2.Exists ("myHighscore")) {
			FB.AppRequest (

				"Can you beat my score: " + ES2.Load<int> ("myHighscore") + " ?",
				null,
				new List<object> (){ "app_users" },
				null,
				null,
				null,
				null,
				ShareWithUsersCallback

			);
		} else {
		
			FB.AppRequest (

				"I challenge you to play SNÖ!",
				null,
				new List<object>(){ "app_users"},
				null,
				null,
				null,
				null,
				ShareWithUsersCallback

			);
		
		}
	}

	void ShareWithUsersCallback(IAppRequestResult result){

		if (result.Cancelled) {

			Debug.Log ("Challenge cancelled");

		} else if (!string.IsNullOrEmpty (result.Error)) {

			Debug.Log ("Error on Challenge");

		} else if (!string.IsNullOrEmpty (result.RawResult)) {

			if (ES2.Exists ("myHighscore")) {
				Debug.Log (FacebookManager.Instance.ProfileName + " scored " + ES2.Load<int> ("myHighscore") + " in SNÖ!");
			} else {
			
				Debug.Log ("succes on Challenge: 0");
			
			}

		}

	}


}
