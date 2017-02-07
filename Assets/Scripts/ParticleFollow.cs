using UnityEngine;
using System.Collections;

public class ParticleFollow : MonoBehaviour {


    public Transform Cube1;
    public Transform Particle1;
    //public float particlePos;
    //public float cubePosX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Particle1.transform.position = new Vector3(Cube1.position.x, Cube1.position.y, 5f); 
        

	}
}
