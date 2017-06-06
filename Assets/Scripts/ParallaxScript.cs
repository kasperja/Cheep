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
	public float distanceBetween = 590f;
	public float numberOfTiles = 4f;
	private Rigidbody2D rbPlayer;

	void Start(){



		origPosLocal = transform.localPosition;

		pc2D = GameObject.Find ("CharacterRobotBoy").GetComponent<PlatformerCharacter2D> ();

		rbPlayer = pc2D.gameObject.GetComponent<Rigidbody2D> ();

		firstMove =( -distanceBetween )* startNumber;

	}

	void Update(){





		if ((transform.localPosition.x - origPosLocal.x) < firstMove) {
		
			transform.localPosition += new Vector3(distanceBetween*numberOfTiles,0f,0f);

		
		}
	
		realSpeed = speed / 1.8f * Time.deltaTime;

		transform.localPosition -= new Vector3(rbPlayer.velocity.x * realSpeed,0f,0f);

	
	}

}
