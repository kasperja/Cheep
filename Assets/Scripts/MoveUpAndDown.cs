using UnityEngine;
using System.Collections;

public class MoveUpAndDown : MonoBehaviour {

	private float angle = 0f;
	private float speed = 2f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		angle += speed * Time.deltaTime;
		transform.position = new Vector3(transform.position.x, 10f * Mathf.Sin (angle) + Screen.height * 0.5f, transform.position.z);
	
	}
}
