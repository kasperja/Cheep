using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterApply : MonoBehaviour {
	private int currentChara = 0;

	public Animator m_Anim;
    public GameObject graphicsAlien;
    public GameObject graphics;
    public GameObject graphicsCat;
    public GameObject graphicsPanda;
    public GameObject graphicsLizard;
    public GameObject graphicsTaco;
    public GameObject graphicsHippo;
    public GameObject graphicsRobby;
    public GameObject graphicsBugo;
    
    public GameObject graphicsHrumpf;
    
    // Use this for initialization
    void Start () {
		
		if (ES2.Exists ("currentChar")) {

			currentChara = ES2.Load<int> ("currentChar");

		}

		if (currentChara == 0) {

            graphicsAlien.SetActive(true);
            graphics.SetActive (false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
			graphicsLizard.SetActive (false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive (false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);

            m_Anim.SetBool("isAlien", true);

        } else if (currentChara == 1) {

            graphicsAlien.SetActive(false);
            graphics.SetActive(true);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);



        }
        else if (currentChara == 2) {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(true);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool ("isCat", true);


		}else if (currentChara == 3) {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(true);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool ("isPanda", true);


		}else if (currentChara == 4) {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(true);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool ("isLizard", true);


		}
        else if (currentChara == 5)
        {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(true);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool("isTaco", true);


        }
        else if (currentChara == 6)
        {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(true);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool("isHippo", true);


        }
        else if (currentChara == 7)
        {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(true);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool("isRobby", true);


        }
        else if (currentChara == 8)
        {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(true);
            graphicsHrumpf.SetActive(false);
            m_Anim.SetBool("isBugo", true);


        }
        else if (currentChara == 9)
        {

            graphicsAlien.SetActive(false);
            graphics.SetActive(false);
            graphicsCat.SetActive(false);
            graphicsPanda.SetActive(false);
            graphicsLizard.SetActive(false);
            graphicsTaco.SetActive(false);
            graphicsHippo.SetActive(false);
            graphicsRobby.SetActive(false);
            graphicsBugo.SetActive(false);
            graphicsHrumpf.SetActive(true);
            m_Anim.SetBool("isHrumpf", true);


        }
        


    }
	
	// Update is called once per frame
	void Update () {



	}
}
