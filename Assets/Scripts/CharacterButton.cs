using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterButton : MonoBehaviour {

	public CharacterSelect charSelectScript;
	// Use this for initialization
	public int thisChar;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void charSelect(){

		charSelectScript.currentChar = thisChar;
		ES2.Save (charSelectScript.currentChar, "currentChar");
	
	}
}
