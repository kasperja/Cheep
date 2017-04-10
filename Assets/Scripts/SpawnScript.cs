using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	private float spawnMinTwo = 1f;
	private float spawnMaxTwo = 2f;
	public PlatformerCharacter2D pc2D;
	private bool spawnReady = false;
	private bool spawnReadyOnce = true;
	private bool coOnce = true;


	//public ObjectPoolManager objm;
	// Use this for initialization
	void Start () {


		//objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
		//Spawn ();

	}

	void Update(){


	
		spawnMinTwo = 10f / pc2D.m_MaxSpeed * spawnMin * 1f;
		spawnMaxTwo = 7.7f / pc2D.m_MaxSpeed * spawnMax * 1f;

		if (spawnReady && spawnReadyOnce) {
			
			Invoke("Spawn", Random.Range(spawnMin, spawnMax));
			spawnReadyOnce = false;

		}
	
	}
	void OnEnable(){

		Spawn ();
		coOnce = true;
		//spawnReadyOnce = true;

	}
	void OnDisable(){
	
		CancelInvoke ("Spawn");
	
	}
	public void Spawn(){


		Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
		//objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
		
		if (coOnce) {
			StartCoroutine (waitStart ());
			coOnce = false;
		}

		if(spawnReady)Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));

	}

	IEnumerator waitStart(){

		yield return new WaitForSeconds (Random.Range (0f, 1f));
		spawnReady = true;

	}

}
