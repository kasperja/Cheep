using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadScene : MonoBehaviour {
    public FadeIn fadeToMain;
	public int lvlNumber = 0;
    public bool isXchar = false;
    public AudioSource buttonSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadSceneOne(){
	
		if(!isXchar)Application.LoadLevel (lvlNumber);

        if (isXchar) StartCoroutine(fadeMainNum());
	
	}
    IEnumerator fadeMainNum() {
        fadeToMain.isStarted = true;
        buttonSound.Play();
        yield return new WaitForSeconds(0.22f);

        Application.LoadLevel(lvlNumber);


    }
}
