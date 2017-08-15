using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUnlockerImages : MonoBehaviour {

    public GameObject[] unlockerCharImages;
    public GameObject[] unlockerLvlImages;
    public Purchaser purchaserScript;
    public bool disableOnce = true;
    public GameObject bgHider;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        

        if (purchaserScript.allCharsUnlocked)
        {
            foreach (GameObject unlockerLvlImage in unlockerLvlImages)
            {
                unlockerLvlImage.SetActive(true);

            }
            gameObject.SetActive(false);

        }
        else
        {
            if (disableOnce)
            {
                foreach (GameObject unlockerCharImage in unlockerCharImages)
                {
                    unlockerCharImage.SetActive(false);

                }

                unlockerCharImages[purchaserScript.nextChar].SetActive(true);
                disableOnce = false;
            }

            foreach (GameObject unlockerLvlImage in unlockerLvlImages)
            {
                unlockerLvlImage.SetActive(false);

            }
        }



            

        }

    
}
