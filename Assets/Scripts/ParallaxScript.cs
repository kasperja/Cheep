using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour {

	private PlatformerCharacter2D pc2D;

	public float speed = 1f;
	private float realSpeed = 0.001f;

	private Vector3 origPosLocal;
	private bool moveOnce = true;
	public float firstMove = -13f;
	public float startNumber;

	void Start(){

		origPosLocal = transform.localPosition;

		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();


		firstMove =( -590f )* startNumber;

	}

	void Update(){





		if ((transform.localPosition.x - origPosLocal.x) < firstMove) {
		
			transform.localPosition += new Vector3(780f+400f+590f,0f,0f);

		
		}
	
		realSpeed = speed / 100f;

		transform.localPosition -= new Vector3(pc2D.m_MaxSpeed * realSpeed,0f,0f);

	
	}

}
