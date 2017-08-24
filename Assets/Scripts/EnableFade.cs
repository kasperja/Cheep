using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFade : MonoBehaviour {

    public bool fadeEnabled = false;
    public GameObject fadeObj;
    public bool isStart = false;
    public static bool isFirstStart = true;


	// Use this for initialization
	void Start () {

        if (ES2.Exists("fadeEnabled"))
        {

            fadeEnabled = ES2.Load<bool>("fadeEnabled");

        }
        if (ES2.Exists("firstStart"))
        {

           // isFirstStart = ES2.Load<bool>("firstStart");

        }

        

        if (fadeEnabled) fadeObj.SetActive(true);


        if (isStart) {

            if (!fadeEnabled)
            {
                fadeObj.SetActive(false);

            }
            else if (isFirstStart)
            {

                fadeObj.SetActive(true);

            }
            

        }

        if (isFirstStart)
        {

            fadeObj.SetActive(true);

        }






    }
	
	// Update is called once per frame
	void Update ()
    {

        if (isFirstStart && isStart)
        {

            fadeObj.SetActive(true);


        }
        else if(isStart && !isFirstStart){

            //fadeObj.SetActive(false);

        }


        isFirstStart = false;

        ES2.Save(isFirstStart, "firstStart");

        fadeEnabled = false;

        ES2.Save(fadeEnabled, "fadeEnabled");

    }
}
