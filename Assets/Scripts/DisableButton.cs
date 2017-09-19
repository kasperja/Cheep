using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour {

    public GameObject textObj;
	// Use this for initialization
	void Start () {

#if UNITY_IOS
    
#elif UNITY_ANDROID

#else

        //gameObject.SetActive(false);

        textObj.SetActive(false);
        gameObject.GetComponent<Button>().enabled = false;
        gameObject.GetComponent<Image>().enabled = false;

#endif

    }

    // Update is called once per frame
    void Update () {

        
		
	}
}
