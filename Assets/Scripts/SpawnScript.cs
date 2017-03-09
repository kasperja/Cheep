using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	private float spawnMinTwo = 1f;
	private float spawnMaxTwo = 2f;
	public PlatformerCharacter2D pc2D;

	public bool isTree = false;
	public Transform camTarget;


	// Use this for initialization
	void Start () {

		//Spawn ();

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
	
		if (false) {
			
			Instantiate (obj [Random.Range (0, obj.Length)], transform.position, new Quaternion(0f,0f, camTarget.rotation.z * 0.9f, 1f));

		} else {
			
			Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
		
		}
		
			Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));
	}
}
