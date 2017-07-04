using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUpImages : MonoBehaviour {
    private int currentChar;
    public GameObject[] imgLvls;
	// Use this for initialization
	void Start () {

        if (ES2.Exists("currentChar"))
        {

            currentChar = ES2.Load<int>("currentChar");

        }

    }
	
	// Update is called once per frame
	void Update () {

        imgLvls[currentChar].SetActive(true);


		
	}
}
