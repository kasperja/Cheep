using UnityEngine;
using System.Collections;

public class RotateCam : MonoBehaviour {

	private float angleMultiplier = 0.1f;
	public PlatformerCharacter2D pc2D;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		angleMultiplier += 0.2f * Time.deltaTime;

		if(!pc2D.isDead) gameObject.transform.Rotate (Vector3.forward * Time.deltaTime * angleMultiplier);

		if (transform.rotation.eulerAngles.z < 90f) {
			
		} else {
			//angleMultiplier = 0f;
			//gameObject.transform.Rotate (Vector3.forward * 0f);
		}
	
	}
}
