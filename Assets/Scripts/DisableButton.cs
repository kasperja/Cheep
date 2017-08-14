using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButton : MonoBehaviour {

	// Use this for initialization
	void Start () {

#if UNITY_IOS
    
#elif UNITY_ANDROID

#else

        gameObject.SetActive(false);

#endif

    }

    // Update is called once per frame
    void Update () {

        
		
	}
}
