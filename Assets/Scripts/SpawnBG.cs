using UnityEngine;
using System.Collections;

public class SpawnBG : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	// Use this for initialization
	void Start () {

		Spawn ();

	}
	void Spawn(){

		Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(transform.position.x + obj[0].GetComponent<SpriteRenderer>().bounds.size.x, transform.position.y, transform.position.z), Quaternion.identity);

		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
