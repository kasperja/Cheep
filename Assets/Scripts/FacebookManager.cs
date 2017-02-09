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

			ProfileName = "   Hi there, " + result.ResultDictionary["first_name"];

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
		
			AppLinkURL = "http://google.com";
		
		}
	
	
	}

	public void Share()

	{
	
		FB.FeedShare (
		
			string.Empty, 
			new Uri(AppLinkURL),
			"Hello this is the title",
			"This is the Caption",
			"Check out this game",
			new Uri("http://i.imgur.com/Qwm5bEV.jpg"),
			string.Empty,
			ShareCallback
		
		);

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
			new Uri("http://i.imgur.com/Qwm5bEV.jpg"),
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

				"Can you beat my score: " + ES2.Load<int> ("myHighscore"),
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

				"Can you beat my score: 0",
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
				Debug.Log ("succes on Challenge: " + ES2.Load<int> ("myHighscore"));
			} else {
			
				Debug.Log ("succes on Challenge: 0");
			
			}

		}

	}


}
