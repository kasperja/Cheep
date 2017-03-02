using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSortOrder : MonoBehaviour {

	// Use this for initialization
	public TrailRenderer trail;
	// Use this for initialization
	void Start () {
		
		trail.sortingOrder = 7;

	}
}
