using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour {

	public int currentChar = 0;

	public int thisChar = 0;

	public GameObject char1;
	public GameObject char2;
	// Use this for initialization
	void Start () {

		if (ES2.Exists ("currentChar")) {

			currentChar = ES2.Load<int> ("currentChar");

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void SelectChar(){

		currentChar = thisChar;

	
	}
}
