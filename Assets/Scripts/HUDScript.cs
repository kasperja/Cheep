﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

	public float playerScore = 0f;

	public float scoreOverTimeAmmount = 10f;

	public PlatformerCharacter2D pc2D;

	public LavineMove lavineScript;
	public bool goDone = false;

	public Text ScoreTxt;
	// Update is called once per frame

    void Start()
    {
        StartCoroutine(textUpdator());

    }
	void LateUpdate () {

		if(goDone && !pc2D.isDead && !lavineScript.isRolling && pc2D.m_MaxSpeed > 5f) playerScore += Time.deltaTime * scoreOverTimeAmmount;
		
	
	}

	public void IncreaseScore (float amount){

		playerScore += amount;
	
	}

	public void OnDisable(){

		ES2.Save ((int)playerScore, "myCurrentScore");

		PlayerPrefs.SetInt ("Score", (int)(playerScore));

	}

    IEnumerator textUpdator() {

        yield return new WaitForSeconds(0.01f);
        ScoreTxt.text = "" + (int)(playerScore);
        StartCoroutine(textUpdator());

    }

	/*void OnGUI()
	{

		GUI.Label (new Rect (Screen.width * 0.2f, Screen.height * 0.2f, Screen.width * 0.5f, Screen.width * 0.1f), "Score: " + (int)(playerScore * 100));

	}*/
}
