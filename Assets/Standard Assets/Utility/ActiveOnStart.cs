using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveOnStart : MonoBehaviour {

    public GameObject setThisObjActive;

    void Awake()
    {

        setThisObjActive.SetActive(true);

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
