using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnScriptUnlocker : MonoBehaviour
{

    public GameObject[] obj;
    public HUDScript hud;
    //public PlatformerCharacter2D pc2D;

    public Text textPickup;

    public float scoreInterval = 1000f;
    public float multiplier = 1f;

    public float numberOfPickups = 0f;
    private float origNumberOfPickups = 0f;

    private bool startOnce = true;
    private bool startTextOnce = false;

    public float finalNumber = 3f;

    private bool char1UnlockedPointsOnce = false;
    private bool char2UnlockedPointsOnce = false;
    private bool char3UnlockedPointsOnce = false;
    private bool char4UnlockedPointsOnce = false;
    private bool char5UnlockedPointsOnce = false;
    private bool char6UnlockedPointsOnce = false;
    private bool char7UnlockedPointsOnce = false;
    private bool char8UnlockedPointsOnce = false;
    private bool char9UnlockedPointsOnce = false;
    private bool char10UnlockedPointsOnce = false;
    private bool char11UnlockedPointsOnce = false;
    private bool char12UnlockedPointsOnce = false;
    private bool char13UnlockedPointsOnce = false;
    private bool char14UnlockedPointsOnce = false;
    private bool char15UnlockedPointsOnce = false;
    private bool char16UnlockedPointsOnce = false;
    private bool char17UnlockedPointsOnce = false;
    private bool char18UnlockedPointsOnce = false;
    private bool char19UnlockedPointsOnce = false;
    private bool char20UnlockedPointsOnce = false;
    private bool char21UnlockedPointsOnce = false;
    private bool char22UnlockedPointsOnce = false;
    private bool char23UnlockedPointsOnce = false;
    private bool char24UnlockedPointsOnce = false;
    private bool char25UnlockedPointsOnce = false;
    private bool char26UnlockedPointsOnce = false;
    private bool char27UnlockedPointsOnce = false;
    private bool char28UnlockedPointsOnce = false;
    private bool char29UnlockedPointsOnce = false;
    private bool char30UnlockedPointsOnce = false;

    public bool char1UnlockedPointsOnceThisGame = false;
    public bool char2UnlockedPointsOnceThisGame = false;
    public bool char3UnlockedPointsOnceThisGame = false;
    public bool char4UnlockedPointsOnceThisGame = false;
    public bool char5UnlockedPointsOnceThisGame = false;
    public bool char6UnlockedPointsOnceThisGame = false;
    public bool char7UnlockedPointsOnceThisGame = false;
    public bool char8UnlockedPointsOnceThisGame = false;
    public bool char9UnlockedPointsOnceThisGame = false;
    public bool char10UnlockedPointsOnceThisGame = false;
    public bool char11UnlockedPointsOnceThisGame = false;
    public bool char12UnlockedPointsOnceThisGame = false;
    public bool char13UnlockedPointsOnceThisGame = false;
    public bool char14UnlockedPointsOnceThisGame = false;
    public bool char15UnlockedPointsOnceThisGame = false;
    public bool char16UnlockedPointsOnceThisGame = false;
    public bool char17UnlockedPointsOnceThisGame = false;
    public bool char18UnlockedPointsOnceThisGame = false;
    public bool char19UnlockedPointsOnceThisGame = false;
    public bool char20UnlockedPointsOnceThisGame = false;
    public bool char21UnlockedPointsOnceThisGame = false;
    public bool char22UnlockedPointsOnceThisGame = false;
    public bool char23UnlockedPointsOnceThisGame = false;
    public bool char24UnlockedPointsOnceThisGame = false;
    public bool char25UnlockedPointsOnceThisGame = false;
    public bool char26UnlockedPointsOnceThisGame = false;
    public bool char27UnlockedPointsOnceThisGame = false;
    public bool char28UnlockedPointsOnceThisGame = false;
    public bool char29UnlockedPointsOnceThisGame = false;
    public bool char30UnlockedPointsOnceThisGame = false;

    public float char1PointsToUnlock = 3f;
    public float char2PointsToUnlock = 6f;
    public float char3PointsToUnlock = 9f;
    public float char4PointsToUnlock = 5f;
    public float char5PointsToUnlock = 7f;
    public float char6PointsToUnlock = 10f;
    public float char7PointsToUnlock = 3f;
    public float char8PointsToUnlock = 4f;
    public float char9PointsToUnlock = 8f;
    public float char10PointsToUnlock = 9f;
    public float char11PointsToUnlock = 5f;
    public float char12PointsToUnlock = 3f;
    public float char13PointsToUnlock = 8f;
    public float char14PointsToUnlock = 10f;
    public float char15PointsToUnlock = 4f;
    public float char16PointsToUnlock = 3f;
    public float char17PointsToUnlock = 6f;
    public float char18PointsToUnlock = 8f;
    public float char19PointsToUnlock = 5f;
    public float char20PointsToUnlock = 7f;
    public float char21PointsToUnlock = 9f;
    public float char22PointsToUnlock = 10f;
    public float char23PointsToUnlock = 6f;
    public float char24PointsToUnlock = 8f;
    public float char25PointsToUnlock = 9f;
    public float char26PointsToUnlock = 3f;
    public float char27PointsToUnlock = 4f;
    public float char28PointsToUnlock = 9f;
    public float char29PointsToUnlock = 10f;
    public float char30PointsToUnlock = 12f;

    public bool allCharsUnlocked = false;

    private GameObject[] gameObjects;
    //public ObjectPoolManager objm;
    // Use this for initialization
    public void DestroyAllObjects()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Unlocker");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }

    void Start()
    {



        if (ES2.Exists("char1Unlock"))
        {

            char1UnlockedPointsOnce = ES2.Load<bool>("char1Unlock");
        }

        if (ES2.Exists("char2Unlock"))
        {

            char2UnlockedPointsOnce = ES2.Load<bool>("char2Unlock");
        }

        if (ES2.Exists("char3Unlock"))
        {

            char3UnlockedPointsOnce = ES2.Load<bool>("char3Unlock");
        }

        if (ES2.Exists("char4Unlock"))
        {

            char4UnlockedPointsOnce = ES2.Load<bool>("char4Unlock");
        }

        if (ES2.Exists("char5Unlock"))
        {

            char5UnlockedPointsOnce = ES2.Load<bool>("char5Unlock");

        }

        if (ES2.Exists("char6Unlock"))
        {

            char6UnlockedPointsOnce = ES2.Load<bool>("char6Unlock");
        }

        if (ES2.Exists("char7Unlock"))
        {

            char7UnlockedPointsOnce = ES2.Load<bool>("char7Unlock");

        }

        if (ES2.Exists("char8Unlock"))
        {

            char8UnlockedPointsOnce = ES2.Load<bool>("char8Unlock");

        }

        if (ES2.Exists("char9Unlock"))
        {

            char9UnlockedPointsOnce = ES2.Load<bool>("char9Unlock");
        }

        if (ES2.Exists("char10Unlock"))
        {

            char10UnlockedPointsOnce = ES2.Load<bool>("char10Unlock");
        }

        if (ES2.Exists("char11Unlock"))
        {

            char11UnlockedPointsOnce = ES2.Load<bool>("char11Unlock");
        }

        if (ES2.Exists("char12Unlock"))
        {

            char12UnlockedPointsOnce = ES2.Load<bool>("char12Unlock");
        }

        if (ES2.Exists("char13Unlock"))
        {

            char13UnlockedPointsOnce = ES2.Load<bool>("char13Unlock");

        }

        if (ES2.Exists("char14Unlock"))
        {

            char14UnlockedPointsOnce = ES2.Load<bool>("char14Unlock");
        }

        if (ES2.Exists("char15Unlock"))
        {

            char15UnlockedPointsOnce = ES2.Load<bool>("char15Unlock");

        }

        if (ES2.Exists("char16Unlock"))
        {

            char16UnlockedPointsOnce = ES2.Load<bool>("char16Unlock");

        }

        if (ES2.Exists("char17Unlock"))
        {

            char17UnlockedPointsOnce = ES2.Load<bool>("char17Unlock");
        }

        if (ES2.Exists("char18Unlock"))
        {

            char18UnlockedPointsOnce = ES2.Load<bool>("char18Unlock");
        }

        if (ES2.Exists("char19Unlock"))
        {

            char19UnlockedPointsOnce = ES2.Load<bool>("char19Unlock");

        }

        if (ES2.Exists("char20Unlock"))
        {

            char20UnlockedPointsOnce = ES2.Load<bool>("char20Unlock");
        }

        if (ES2.Exists("char21Unlock"))
        {

            char21UnlockedPointsOnce = ES2.Load<bool>("char21Unlock");

        }

        if (ES2.Exists("char22Unlock"))
        {

            char22UnlockedPointsOnce = ES2.Load<bool>("char22Unlock");

        }

        if (ES2.Exists("char23Unlock"))
        {

            char23UnlockedPointsOnce = ES2.Load<bool>("char23Unlock");
        }

        if (ES2.Exists("char24Unlock"))
        {

            char24UnlockedPointsOnce = ES2.Load<bool>("char24Unlock");
        }

        if (ES2.Exists("char25Unlock"))
        {

            char25UnlockedPointsOnce = ES2.Load<bool>("char25Unlock");
        }

        if (ES2.Exists("char26Unlock"))
        {

            char26UnlockedPointsOnce = ES2.Load<bool>("char26Unlock");
        }

        if (ES2.Exists("char27Unlock"))
        {

            char27UnlockedPointsOnce = ES2.Load<bool>("char27Unlock");

        }

        if (ES2.Exists("char28Unlock"))
        {

            char28UnlockedPointsOnce = ES2.Load<bool>("char28Unlock");
        }

        if (ES2.Exists("char29Unlock"))
        {

            char29UnlockedPointsOnce = ES2.Load<bool>("char29Unlock");

        }



        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            char26UnlockedPointsOnce &&
            char27UnlockedPointsOnce &&
            char28UnlockedPointsOnce &&
            char29UnlockedPointsOnce)
        {

            allCharsUnlocked = true;


        }

        //objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
        //Spawn ();

    }

    void Update()
    {

        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            char26UnlockedPointsOnce &&
            char27UnlockedPointsOnce &&
            char28UnlockedPointsOnce &&
            char29UnlockedPointsOnce)
        {

            allCharsUnlocked = true;


        }

        if (!allCharsUnlocked)
        {

            if ((numberOfPickups > origNumberOfPickups) || startTextOnce)
            {
                textPickup.text = "" + (int)numberOfPickups + "/" + (int)finalNumber + " ";


                origNumberOfPickups = numberOfPickups;
                startTextOnce = false;
            }

        }
        else
        {

            textPickup.text = "";

        }
        if (!allCharsUnlocked && (hud.playerScore >= (scoreInterval * multiplier)))
        {

            multiplier += 1f;
            Spawn();



            //numberOfPickups += 1f;



        }

        /*	if (char30UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char29UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char28UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char27UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char26UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char25UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char24UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char23UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char22UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char21UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char20UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char19UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char18UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char13UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char15UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char16UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char17UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char18UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char19UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char20UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char21UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char22UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char23UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char24UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char25UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char26UnlockedPointsOnce) {

                finalNumber = 30f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char27UnlockedPointsOnce) {

                finalNumber = 7f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char28UnlockedPointsOnce) {

                finalNumber = 5f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char29UnlockedPointsOnce) {

                finalNumber = 9f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else if (char30UnlockedPointsOnce) {

                finalNumber = 6f;
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            } else {
                if (startOnce) {

                    startTextOnce = true;
                    startOnce = false;

                }

            }


    */

        if (startOnce)
        {
            startTextOnce = true;
            startOnce = false;
        }

        if (!char1UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char1PointsToUnlock)
            {
                finalNumber = char2PointsToUnlock;
                numberOfPickups = 0f;
                char1UnlockedPointsOnce = true;
                char1UnlockedPointsOnceThisGame = true;
                ES2.Save(char1UnlockedPointsOnce, "char1Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char1PointsToUnlock;
            }

        }
        if (char1UnlockedPointsOnce &&
            !char2UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char2PointsToUnlock)
            {
                finalNumber = char3PointsToUnlock;
                numberOfPickups = 0f;
                char2UnlockedPointsOnce = true;
                char2UnlockedPointsOnceThisGame = true;
                ES2.Save(char2UnlockedPointsOnce, "char2Unlock");
                DestroyAllObjects();
                startTextOnce = true;
            }
            else
            {

                finalNumber = char2PointsToUnlock;
            }

        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            !char3UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char3PointsToUnlock)
            {
                finalNumber = char4PointsToUnlock;
                numberOfPickups = 0f;
                char3UnlockedPointsOnce = true;
                char3UnlockedPointsOnceThisGame = true;
                ES2.Save(char3UnlockedPointsOnce, "char3Unlock");
                DestroyAllObjects();
                startTextOnce = true;
            }
            else
            {

                finalNumber = char3PointsToUnlock;
            }

        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            !char4UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char4PointsToUnlock)
            {
                finalNumber = char5PointsToUnlock;
                numberOfPickups = 0f;
                char4UnlockedPointsOnce = true;
                char4UnlockedPointsOnceThisGame = true;
                ES2.Save(char4UnlockedPointsOnce, "char4Unlock");
                DestroyAllObjects();
                startTextOnce = true;
            }
            else
            {

                finalNumber = char4PointsToUnlock;
            }

        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            !char5UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char5PointsToUnlock)
            {
                finalNumber = char6PointsToUnlock;
                numberOfPickups = 0f;
                char5UnlockedPointsOnce = true;
                char5UnlockedPointsOnceThisGame = true;
                ES2.Save(char5UnlockedPointsOnce, "char5Unlock");
                DestroyAllObjects();
                startTextOnce = true;
            }
            else
            {

                finalNumber = char5PointsToUnlock;
            }

        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            !char6UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char6PointsToUnlock)
            {
                finalNumber = char7PointsToUnlock;
                numberOfPickups = 0f;
                char6UnlockedPointsOnce = true;
                char6UnlockedPointsOnceThisGame = true;
                ES2.Save(char6UnlockedPointsOnce, "char6Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char6PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            !char7UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char7PointsToUnlock)
            {
                finalNumber = char8PointsToUnlock;
                numberOfPickups = 0f;
                char7UnlockedPointsOnce = true;
                char7UnlockedPointsOnceThisGame = true;
                ES2.Save(char7UnlockedPointsOnce, "char7Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char7PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            !char8UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char8PointsToUnlock)
            {
                finalNumber = char9PointsToUnlock;
                numberOfPickups = 0f;
                char8UnlockedPointsOnce = true;
                char8UnlockedPointsOnceThisGame = true;
                ES2.Save(char8UnlockedPointsOnce, "char8Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char8PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            !char9UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char9PointsToUnlock)
            {
                finalNumber = char10PointsToUnlock;
                numberOfPickups = 0f;
                char9UnlockedPointsOnce = true;
                char9UnlockedPointsOnceThisGame = true;
                ES2.Save(char9UnlockedPointsOnce, "char9Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char9PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            !char10UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char10PointsToUnlock)
            {
                finalNumber = char11PointsToUnlock;
                numberOfPickups = 0f;
                char10UnlockedPointsOnce = true;
                char10UnlockedPointsOnceThisGame = true;
                ES2.Save(char10UnlockedPointsOnce, "char10Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char10PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            !char11UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char11PointsToUnlock)
            {
                finalNumber = char12PointsToUnlock;
                numberOfPickups = 0f;
                char11UnlockedPointsOnce = true;
                char11UnlockedPointsOnceThisGame = true;
                ES2.Save(char11UnlockedPointsOnce, "char11Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char11PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            !char12UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char12PointsToUnlock)
            {
                finalNumber = char13PointsToUnlock;
                numberOfPickups = 0f;
                char12UnlockedPointsOnce = true;
                char12UnlockedPointsOnceThisGame = true;
                ES2.Save(char12UnlockedPointsOnce, "char12Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char12PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            !char13UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char13PointsToUnlock)
            {
                finalNumber = char14PointsToUnlock;
                numberOfPickups = 0f;
                char13UnlockedPointsOnce = true;
                char13UnlockedPointsOnceThisGame = true;
                ES2.Save(char13UnlockedPointsOnce, "char13Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char13PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            !char14UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char14PointsToUnlock)
            {
                finalNumber = char15PointsToUnlock;
                numberOfPickups = 0f;
                char14UnlockedPointsOnce = true;
                char14UnlockedPointsOnceThisGame = true;
                ES2.Save(char14UnlockedPointsOnce, "char14Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char14PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            !char15UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char15PointsToUnlock)
            {
                finalNumber = char16PointsToUnlock;
                numberOfPickups = 0f;
                char15UnlockedPointsOnce = true;
                char15UnlockedPointsOnceThisGame = true;
                ES2.Save(char15UnlockedPointsOnce, "char15Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char15PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            !char16UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char16PointsToUnlock)
            {
                finalNumber = char17PointsToUnlock;
                numberOfPickups = 0f;
                char16UnlockedPointsOnce = true;
                char16UnlockedPointsOnceThisGame = true;
                ES2.Save(char16UnlockedPointsOnce, "char16Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char16PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            !char17UnlockedPointsOnce)
        {

            if (numberOfPickups >= char17PointsToUnlock)
            {
                finalNumber = char18PointsToUnlock;
                numberOfPickups = 0f;
                char17UnlockedPointsOnce = true;
                char17UnlockedPointsOnceThisGame = true;
                ES2.Save(char17UnlockedPointsOnce, "char17Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char17PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            !char18UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char18PointsToUnlock)
            {
                finalNumber = char19PointsToUnlock;
                numberOfPickups = 0f;
                char18UnlockedPointsOnce = true;
                char18UnlockedPointsOnceThisGame = true;
                ES2.Save(char18UnlockedPointsOnce, "char18Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char18PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            !char19UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char19PointsToUnlock)
            {
                finalNumber = char20PointsToUnlock;
                numberOfPickups = 0f;
                char19UnlockedPointsOnce = true;
                char19UnlockedPointsOnceThisGame = true;
                ES2.Save(char19UnlockedPointsOnce, "char19Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char19PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            !char20UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char20PointsToUnlock)
            {
                finalNumber = char21PointsToUnlock;
                numberOfPickups = 0f;
                char20UnlockedPointsOnce = true;
                char20UnlockedPointsOnceThisGame = true;
                ES2.Save(char20UnlockedPointsOnce, "char20Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char20PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            !char21UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char21PointsToUnlock)
            {
                finalNumber = char22PointsToUnlock;
                numberOfPickups = 0f;
                char21UnlockedPointsOnce = true;
                char21UnlockedPointsOnceThisGame = true;
                ES2.Save(char21UnlockedPointsOnce, "char21Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char21PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            !char22UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char22PointsToUnlock)
            {
                finalNumber = char23PointsToUnlock;
                numberOfPickups = 0f;
                char22UnlockedPointsOnce = true;
                char22UnlockedPointsOnceThisGame = true;
                ES2.Save(char22UnlockedPointsOnce, "char22Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char22PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            !char23UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char23PointsToUnlock)
            {
                finalNumber = char24PointsToUnlock;
                numberOfPickups = 0f;
                char23UnlockedPointsOnce = true;
                char23UnlockedPointsOnceThisGame = true;
                ES2.Save(char23UnlockedPointsOnce, "char23Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char23PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            !char24UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char24PointsToUnlock)
            {
                finalNumber = char25PointsToUnlock;
                numberOfPickups = 0f;
                char24UnlockedPointsOnce = true;
                char24UnlockedPointsOnceThisGame = true;
                ES2.Save(char24UnlockedPointsOnce, "char24Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char24PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            !char25UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char26PointsToUnlock)
            {
                finalNumber = char27PointsToUnlock;
                numberOfPickups = 0f;
                char25UnlockedPointsOnce = true;
                char25UnlockedPointsOnceThisGame = true;
                ES2.Save(char25UnlockedPointsOnce, "char25Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char26PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            !char26UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char26PointsToUnlock)
            {
                finalNumber = char27PointsToUnlock;
                numberOfPickups = 0f;
                char26UnlockedPointsOnce = true;
                char26UnlockedPointsOnceThisGame = true;
                ES2.Save(char26UnlockedPointsOnce, "char26Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char26PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            char26UnlockedPointsOnce &&
            !char27UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char27PointsToUnlock)
            {
                finalNumber = char28PointsToUnlock;
                numberOfPickups = 0f;
                char27UnlockedPointsOnce = true;
                char27UnlockedPointsOnceThisGame = true;
                ES2.Save(char27UnlockedPointsOnce, "char27Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char27PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            char26UnlockedPointsOnce &&
            char27UnlockedPointsOnce &&
            !char28UnlockedPointsOnce &&
            !allCharsUnlocked)
        {

            if (numberOfPickups >= char28PointsToUnlock)
            {
                finalNumber = char29PointsToUnlock;
                numberOfPickups = 0f;
                char28UnlockedPointsOnce = true;
                char28UnlockedPointsOnceThisGame = true;
                ES2.Save(char28UnlockedPointsOnce, "char28Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char28PointsToUnlock;
            }
        }
        if (char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            char13UnlockedPointsOnce &&
            char14UnlockedPointsOnce &&
            char15UnlockedPointsOnce &&
            char16UnlockedPointsOnce &&
            char17UnlockedPointsOnce &&
            char18UnlockedPointsOnce &&
            char19UnlockedPointsOnce &&
            char20UnlockedPointsOnce &&
            char21UnlockedPointsOnce &&
            char22UnlockedPointsOnce &&
            char23UnlockedPointsOnce &&
            char24UnlockedPointsOnce &&
            char25UnlockedPointsOnce &&
            char26UnlockedPointsOnce &&
            char27UnlockedPointsOnce &&
            char28UnlockedPointsOnce &&
            !char29UnlockedPointsOnce
            )
        {

            if (numberOfPickups >= char29PointsToUnlock)
            {
                finalNumber = 30f;
                textPickup.text = " ";
                numberOfPickups = 0f;
                char29UnlockedPointsOnce = true;
                char29UnlockedPointsOnceThisGame = true;
                ES2.Save(char29UnlockedPointsOnce, "char29Unlock");
                DestroyAllObjects();
                startTextOnce = true;

            }
            else
            {

                finalNumber = char29PointsToUnlock;
            }
        }

    }




    public void Spawn()
    {

        if (!char1UnlockedPointsOnce)
        {

            Instantiate(obj[0], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 1 spawn");

        }
        else if (
          char1UnlockedPointsOnce &&
          !char2UnlockedPointsOnce)
        {

            Instantiate(obj[1], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 2 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           !char3UnlockedPointsOnce)
        {

            Instantiate(obj[2], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 3 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           char3UnlockedPointsOnce &&
           !char4UnlockedPointsOnce)
        {

            Instantiate(obj[3], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 4 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           char3UnlockedPointsOnce &&
           char4UnlockedPointsOnce &&
           !char5UnlockedPointsOnce)
        {

            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 5 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           char3UnlockedPointsOnce &&
           char4UnlockedPointsOnce &&
           char5UnlockedPointsOnce &&
           !char6UnlockedPointsOnce)
        {

            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 6 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           char3UnlockedPointsOnce &&
           char4UnlockedPointsOnce &&
           char5UnlockedPointsOnce &&
           char6UnlockedPointsOnce &&
           !char7UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [6], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 7 spawn");
        }
        else if (
           char1UnlockedPointsOnce &&
           char2UnlockedPointsOnce &&
           char3UnlockedPointsOnce &&
           char4UnlockedPointsOnce &&
           char5UnlockedPointsOnce &&
           char6UnlockedPointsOnce &&
           char7UnlockedPointsOnce &&
           !char8UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 8 spawn");
        }
        else if (
            char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            !char9UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 9 spawn");
        }
        else if (
            char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            !char10UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 10 spawn");
        }
        else if (
            char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            !char11UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 11 spawn");
        }
        else if (
            char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            !char12UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 12 spawn");
        }
        else if (
            char1UnlockedPointsOnce &&
            char2UnlockedPointsOnce &&
            char3UnlockedPointsOnce &&
            char4UnlockedPointsOnce &&
            char5UnlockedPointsOnce &&
            char6UnlockedPointsOnce &&
            char7UnlockedPointsOnce &&
            char8UnlockedPointsOnce &&
            char9UnlockedPointsOnce &&
            char10UnlockedPointsOnce &&
            char11UnlockedPointsOnce &&
            char12UnlockedPointsOnce &&
            !char13UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 13 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             !char14UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 14 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             !char15UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 15 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             !char16UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 16 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             !char17UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 17 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             !char18UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 18 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             !char19UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 19 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             !char20UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 20 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             !char21UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 21 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             !char22UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 22 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             !char23UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 23 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             !char24UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 24 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             char24UnlockedPointsOnce &&
             !char25UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 25 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             char24UnlockedPointsOnce &&
             char25UnlockedPointsOnce &&
             !char26UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 26 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             char24UnlockedPointsOnce &&
             char25UnlockedPointsOnce &&
             char26UnlockedPointsOnce &&
             !char27UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 27 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             char24UnlockedPointsOnce &&
             char25UnlockedPointsOnce &&
             char26UnlockedPointsOnce &&
             char27UnlockedPointsOnce &&
             !char28UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 28 spawn");
        }
        else if (
             char1UnlockedPointsOnce &&
             char2UnlockedPointsOnce &&
             char3UnlockedPointsOnce &&
             char4UnlockedPointsOnce &&
             char5UnlockedPointsOnce &&
             char6UnlockedPointsOnce &&
             char7UnlockedPointsOnce &&
             char8UnlockedPointsOnce &&
             char9UnlockedPointsOnce &&
             char10UnlockedPointsOnce &&
             char11UnlockedPointsOnce &&
             char12UnlockedPointsOnce &&
             char13UnlockedPointsOnce &&
             char14UnlockedPointsOnce &&
             char15UnlockedPointsOnce &&
             char16UnlockedPointsOnce &&
             char17UnlockedPointsOnce &&
             char18UnlockedPointsOnce &&
             char19UnlockedPointsOnce &&
             char20UnlockedPointsOnce &&
             char21UnlockedPointsOnce &&
             char22UnlockedPointsOnce &&
             char23UnlockedPointsOnce &&
             char24UnlockedPointsOnce &&
             char25UnlockedPointsOnce &&
             char26UnlockedPointsOnce &&
             char27UnlockedPointsOnce &&
             char28UnlockedPointsOnce &&
             !char29UnlockedPointsOnce)
        {
            Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
            Debug.Log("p 29 spawn");
        }






    }





}