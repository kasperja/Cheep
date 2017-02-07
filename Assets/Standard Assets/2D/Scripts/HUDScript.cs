using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

	public float playerScore = 0f;

	public PlatformerCharacter2D pc2D;

	public Text ScoreTxt;
	// Update is called once per frame
	void Update () {

		if(!pc2D.isDead) playerScore += Time.deltaTime * 100f;
		ScoreTxt.text = "" + (int)( playerScore);
	
	}

	public void IncreaseScore (float amount){
	
		playerScore += amount;
	
	}

	public void OnDisable(){

		PlayerPrefs.SetInt ("Score", (int)(playerScore));

	}

	/*void OnGUI()
	{

		GUI.Label (new Rect (Screen.width * 0.2f, Screen.height * 0.2f, Screen.width * 0.5f, Screen.width * 0.1f), "Score: " + (int)(playerScore * 100));

	}*/
}
