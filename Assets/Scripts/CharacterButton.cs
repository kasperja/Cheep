using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CharacterButton : MonoBehaviour {

	public CharacterSelect charSelectScript;
	// Use this for initialization
	public int thisChar;

	public AudioSource buttonSound;

	private FadeOut fadeOutScript;

    public GameObject popupObj;
    public BuyThis buyThisScript;
    //public ParticleSystem selectedParticle;

    //public ParticleSystem[] otherParticles;
    public GameObject loadingText;

    

    void Start () {

		fadeOutScript = GameObject.Find ("FadeOut").GetComponent<FadeOut>();
		//selectedParticle = charSelectScript.gameObject.GetComponentInChildren<ParticleSystem> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
		
		
			buttonSound.Play();
			StartCoroutine (waitAndStart());
		
		}
		
	}

    public void showPopup() {

        charSelectScript.currentChar = thisChar;
        ES2.Save(charSelectScript.currentChar, "currentChar");
        buyThisScript.currentChar = thisChar;
        popupObj.SetActive(true);


    }

	public void charSelect(){

		/*for(int i = 0; i < otherParticles.Length; i++){

			otherParticles [i].Stop ();

		}*/



		charSelectScript.currentChar = thisChar;
		ES2.Save (charSelectScript.currentChar, "currentChar");
		//selectedParticle.Play ();
		buttonSound.Play();
		StartCoroutine (waitAndStart());
		charSelectScript.SelectParticleFunction (thisChar);
	
	}

	IEnumerator waitAndStart(){
	
		fadeOutScript.isStarted = true;
        DontDestroyOnLoadScript.endMenuMusic = true;
		yield return new WaitForSeconds (0.15f);
        DontDestroyOnLoadScript.endMenuMusic = false;
        loadingText.SetActive(true);
		Application.LoadLevel (1);
	
	}
}
