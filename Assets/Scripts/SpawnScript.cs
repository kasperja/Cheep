using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	private float spawnMinTwo = 1f;
	private float spawnMaxTwo = 2f;
	public PlatformerCharacter2D pc2D;


	// Use this for initialization
	void Start () {

		//if(isPowerup)Spawn ();

	}

	void Update(){
	
		spawnMinTwo = 10f / pc2D.m_MaxSpeed * spawnMin * 1f;
		spawnMaxTwo = 7.7f / pc2D.m_MaxSpeed * spawnMax * 1f;

		 
	
	}
	void OnEnable(){

		Spawn ();

	}
	void OnDisable(){
	
		CancelInvoke ("Spawn");
	
	}
	public void Spawn(){
	
		Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
		
			Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));
	}
}
