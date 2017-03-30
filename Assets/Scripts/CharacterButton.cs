using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterButton : MonoBehaviour {

	public CharacterSelect charSelectScript;
	// Use this for initialization
	public int thisChar;

	public ParticleSystem selectedParticle;

	//public ParticleSystem[] otherParticles;

	void Start () {

		//selectedParticle = charSelectScript.gameObject.GetComponentInChildren<ParticleSystem> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void charSelect(){

		/*for(int i = 0; i < otherParticles.Length; i++){

			otherParticles [i].Stop ();

		}*/



		charSelectScript.currentChar = thisChar;
		ES2.Save (charSelectScript.currentChar, "currentChar");
		selectedParticle.Play ();
		charSelectScript.SelectParticleFunction (thisChar);
	
	}
}
