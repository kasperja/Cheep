using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshSorting : MonoBehaviour {

	public int sortingLayer = 0;
	public MeshRenderer meshRenderer;
	// Use this for initialization
	void Start () {

		meshRenderer.sortingOrder = sortingLayer;
		
	}
	
	// Update is called once per frame
	void Update () {



	}
}
