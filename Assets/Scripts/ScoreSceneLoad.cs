using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSceneLoad : MonoBehaviour {
    public FadeOut fadeOutScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadScores(){
	
		ES2.Delete ("myCurrentScore");
        StartCoroutine(scoreNum());
	
	}

    IEnumerator scoreNum()
    {

        fadeOutScript.isStarted = true;
        //StartCoroutine(StartAsync());
        yield return new WaitForSeconds(0.2f);
        Application.LoadLevel(2);



    }
}
