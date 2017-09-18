using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	public FadeOut fadeOutScript;
	public AudioSource buttonSound;
	private bool deleteSaves = false;
    //private bool char1UnlockedPointsOnce = true;
    // Use this for initialization
    void Start () {
        
        ES2.Save (0, "prevScene");
        // ES2.Save(char1UnlockedPointsOnce, "char1Unlock");
        

    }

    IEnumerator StartAsync()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync("CharScene", LoadSceneMode.Single);
        yield return async;
        Debug.Log("Loading complete");
    }
    void Awake(){


		//Resources.LoadAll ("Textures/Menuer");
		//Resources.LoadAll ("Sound/Music");

		Application.targetFrameRate = 60;
	
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return) /*|| (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began*/) {

			Retry ();

		}
		/*if (Input.GetKey ("escape")) {
			Application.Quit ();
		}*/
	
		//if(Input.GetKeyDown (KeyCode.O) || deleteSaves)ES2.DeleteDefaultFolder();

	}

	public void Retry(){

		buttonSound.Play ();
		StartCoroutine (retryNum ());

	}

    public void DeleteSaves() {

        ES2.DeleteDefaultFolder();


    }


	IEnumerator retryNum (){
        
        fadeOutScript.isStarted = true;
        //StartCoroutine(StartAsync());
        yield return new WaitForSeconds (0.2f);
		Application.LoadLevel (3);



	}

    

    /*void OnApplicationQuit () {
		PlayerPrefs.SetInt("Screenmanager Resolution Width", 854);
		PlayerPrefs.SetInt("Screenmanager Resolution Height", 480);
		PlayerPrefs.SetInt("Screenmanager Is Fullscreen mode", 0);
	}*/


}
