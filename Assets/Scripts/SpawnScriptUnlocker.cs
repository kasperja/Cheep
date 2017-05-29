using UnityEngine;
using System.Collections;

public class SpawnScriptUnlocker : MonoBehaviour {

	public GameObject[] obj;
	public HUDScript hud;
	public PlatformerCharacter2D pc2D;

	public bool spawnOnce = true;

	//public ObjectPoolManager objm;
	// Use this for initialization
	void Start () {


		//objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
		Spawn ();

	}

	void Update(){

		if (hud.playerScore > 1000f) {
			spawnOnce = true;

			Spawn ();
			spawnOnce = false;
		}

	}

	public void Spawn(){

		Instantiate(obj[Random.Range(0, obj.Length-1)], transform.position, Quaternion.identity);



	}



}

