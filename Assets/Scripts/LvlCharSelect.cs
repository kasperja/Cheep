using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlCharSelect : MonoBehaviour {

    private int currentChar = 0;
    private float[] currentLvlAchievements;
    private Text lvlTxt;
    private float lvl = 1f;
    private float cLvl = 1f;
    private float nextLvl = 2f;
    public Text nameAndLvlTxt;
    private string nameAndLvl;
    public string nameOnly;

    // Use this for initialization
    void Start () {

        currentLvlAchievements = new float[30];
        lvlTxt = gameObject.GetComponent<Text>();
       // nameOnly = nameAndLvlTxt.text;
		
	}
	
	// Update is called once per frame
	void Update () {


        if (ES2.Exists("currentChar"))
        {

            currentChar = ES2.Load<int>("currentChar");

        }

        if (ES2.Exists("a" + currentChar))
        {

           cLvl =  ES2.Load<float>("a" + currentChar);

           lvl = cLvl / 1f + 1f;

            nextLvl = cLvl + 2f;

        }

        nameAndLvlTxt.text = nameOnly + " - lvl " + lvl;

        lvlTxt.text = "Next level:  Get " + nextLvl + " ";


        

    }
}
