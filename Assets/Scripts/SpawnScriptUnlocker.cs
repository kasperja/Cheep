using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnScriptUnlocker : MonoBehaviour
{

    public bool spawnEnabled = true;
    public float maxSpawnHeight = 4f;


    public GameObject[] obj;
    public GameObject[] objAchievements;
    public GameObject[] objHUD;
    public GameObject[] objHUDAchievements;
    public HUDScript hud;

    public int currentChar = 0;

    public float achievementIncreaseInterval = 1f;

    private bool isFirstStart = true;
    //public PlatformerCharacter2D pc2D;

    public Text textPickup;

    public float scoreInterval = 1000f;
    public float timeInterval = 10f;
    public float hrumpfTimeInterval = 2f;
    private bool spawnReady = true;

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
   

    private bool char1UnlockedPointsOnce2 = false;
    private bool char2UnlockedPointsOnce2 = false;
    private bool char3UnlockedPointsOnce2 = false;
    private bool char4UnlockedPointsOnce2 = false;
    private bool char5UnlockedPointsOnce2 = false;
    private bool char6UnlockedPointsOnce2 = false;
    private bool char7UnlockedPointsOnce2 = false;
    private bool char8UnlockedPointsOnce2 = false;
    private bool char9UnlockedPointsOnce2 = false;
    private bool char10UnlockedPointsOnce2 = false;
    private bool char11UnlockedPointsOnce2 = false;
    private bool char12UnlockedPointsOnce2 = false;
    private bool char13UnlockedPointsOnce2 = false;
    private bool char14UnlockedPointsOnce2 = false;
    private bool char15UnlockedPointsOnce2 = false;
    private bool char16UnlockedPointsOnce2 = false;
    private bool char17UnlockedPointsOnce2 = false;
    private bool char18UnlockedPointsOnce2 = false;
    private bool char19UnlockedPointsOnce2 = false;
    private bool char20UnlockedPointsOnce2 = false;
    private bool char21UnlockedPointsOnce2 = false;
    private bool char22UnlockedPointsOnce2 = false;
    private bool char23UnlockedPointsOnce2 = false;
    private bool char24UnlockedPointsOnce2 = false;
    private bool char25UnlockedPointsOnce2 = false;
    private bool char26UnlockedPointsOnce2 = false;
    private bool char27UnlockedPointsOnce2 = false;
    private bool char28UnlockedPointsOnce2 = false;
    private bool char29UnlockedPointsOnce2 = false;

    private bool destroyOnce = true;
  
    public bool OneCharUnlockedThisGame = false;
    public Image pickupImg;
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
    

    public float char1PointsToUnlock;
    public float char2PointsToUnlock;
    public float char3PointsToUnlock;
    public float char4PointsToUnlock;
    public float char5PointsToUnlock;
    public float char6PointsToUnlock;
    public float char7PointsToUnlock;
    public float char8PointsToUnlock;
    public float char9PointsToUnlock;
    public float char10PointsToUnlock;
    public float char11PointsToUnlock;
    public float char12PointsToUnlock;
    public float char13PointsToUnlock;
    public float char14PointsToUnlock;
    public float char15PointsToUnlock;
    public float char16PointsToUnlock;
    public float char17PointsToUnlock;
    public float char18PointsToUnlock;
    public float char19PointsToUnlock;
    public float char20PointsToUnlock;
    public float char21PointsToUnlock;
    public float char22PointsToUnlock;
    public float char23PointsToUnlock;
    public float char24PointsToUnlock;
    public float char25PointsToUnlock;
    public float char26PointsToUnlock;
    public float char27PointsToUnlock;
    public float char28PointsToUnlock;
    public float char29PointsToUnlock;
    public float char30PointsToUnlock;

    public bool allCharsUnlocked = false;

    public AudioSource pickupUnlockerSound;

    public Animator UIanimator;


    private GameObject[] gameObjects;
    private GameObject[] gameObjectsUnlocker;
    private GameObject[] gameObjectsUnlockerParent;
    private GameObject[] gameObjectsSuper;
    private GameObject[] gameObjectsNorm;

    public GameObject UIimages;

    public bool achiementsActivated = false;
    public float[] achievementMaxPoints;
    public bool achievemntUnlockedThisGame = false;

    private bool falseOnceUI = true;

    public AudioSource unlockSound;
    public AudioSource unlockSoundApplause;
    private bool soundOnce = true;

    public GameObject popupAchievement;

    private int nextChar = 1;

    public float[] currentLvlAchievements;
    //public ObjectPoolManager objm;
    // Use this for initialization
    public void DestroyAllObjects()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Unlocker");

        for (var i = 0; i < gameObjects.Length; i++)
        {

          //  Destroy(gameObjects[i]);
        }
    }
    public void DestroyAllObjectsUnlocker()
    {
        gameObjectsUnlocker = GameObject.FindGameObjectsWithTag("Unlocker");

        for (var i = 0; i < gameObjectsUnlocker.Length; i++)
        {

            if (!gameObjectsUnlocker[i].GetComponentInChildren<SpriteRenderer>().isVisible) Destroy(gameObjectsUnlocker[i].transform.parent.gameObject);
        }

        

    }
    public void DestroyAllObjectsSuper()
    {
        gameObjectsSuper = GameObject.FindGameObjectsWithTag("PowerupSuper");

        for (var i = 0; i < gameObjectsSuper.Length; i++)
        {

            if (!gameObjectsSuper[i].GetComponent<SpriteRenderer>().isVisible) Destroy(gameObjectsSuper[i]);
        }
    }
    public void DestroyAllObjectsNorm()
    {
        gameObjectsNorm = GameObject.FindGameObjectsWithTag("Powerup");

        for (var i = 0; i < gameObjectsNorm.Length; i++)
        {

            if (!gameObjectsNorm[i].GetComponent<SpriteRenderer>().isVisible) Destroy(gameObjectsNorm[i]);
        }
    }

    /*void OnEnable()
    {
        if (!isFirstStart) {

            if (!char1UnlockedPointsOnceThisGame &&
               !char2UnlockedPointsOnceThisGame &&
               !char3UnlockedPointsOnceThisGame &&
               !char4UnlockedPointsOnceThisGame &&
               !char5UnlockedPointsOnceThisGame &&
               !char6UnlockedPointsOnceThisGame &&
               !char7UnlockedPointsOnceThisGame &&
               !char8UnlockedPointsOnceThisGame &&
               !char9UnlockedPointsOnceThisGame &&
               !char10UnlockedPointsOnceThisGame && !achievemntUnlockedThisGame && !OneCharUnlockedThisGame) { StartCoroutine(SpawnNum(timeInterval)); }
            else {


                DestroyAllObjectsUnlocker();
                DestroyAllObjects();

            }

        } else
        {

            isFirstStart = false;
        }


    }*/

    void Start()
    {
        if (ES2.Exists("nextChar")) nextChar = ES2.Load<int>("nextChar");

        if (ES2.Exists("currentChar"))
        {

            currentChar = ES2.Load<int>("currentChar");

        }

        if (ES2.Exists("a"+currentChar))
        {

            currentLvlAchievements[currentChar] = ES2.Load<float>("a"+currentChar);

        }

        if (currentLvlAchievements[currentChar] >= achievementMaxPoints[currentChar]) {

            achievementMaxPoints[currentChar] = currentLvlAchievements[currentChar] + achievementIncreaseInterval;

        }

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
        if (ES2.Exists("char1Purchased"))
        {

            char1UnlockedPointsOnce2 = ES2.Load<bool>("char1Purchased");
        }

        if (ES2.Exists("char2Purchased"))
        {

            char2UnlockedPointsOnce2 = ES2.Load<bool>("char2Purchased");
        }

        if (ES2.Exists("char3Purchased"))
        {

            char3UnlockedPointsOnce2 = ES2.Load<bool>("char3Purchased");
        }

        if (ES2.Exists("char4Purchased"))
        {

            char4UnlockedPointsOnce2 = ES2.Load<bool>("char4Purchased");
        }

        if (ES2.Exists("char5Purchased"))
        {

            char5UnlockedPointsOnce2 = ES2.Load<bool>("char5Purchased");

        }

        if (ES2.Exists("char6Purchased"))
        {

            char6UnlockedPointsOnce2 = ES2.Load<bool>("char6Purchased");
        }

        if (ES2.Exists("char7Purchased"))
        {

            char7UnlockedPointsOnce2 = ES2.Load<bool>("char7Purchased");

        }

        if (ES2.Exists("char8Purchased"))
        {

            char8UnlockedPointsOnce2 = ES2.Load<bool>("char8Purchased");

        }

        if (ES2.Exists("char9Purchased"))
        {

            char9UnlockedPointsOnce2 = ES2.Load<bool>("char9Purchased");
        }

        if (ES2.Exists("char10Purchased"))
        {

            char10UnlockedPointsOnce2 = ES2.Load<bool>("char10Purchased");
        }

        if (ES2.Exists("char11Purchased"))
        {

            char11UnlockedPointsOnce2 = ES2.Load<bool>("char11Purchased");
        }

        if (ES2.Exists("char12Purchased"))
        {

            char12UnlockedPointsOnce2 = ES2.Load<bool>("char12Purchased");
        }

        if (ES2.Exists("char13Purchased"))
        {

            char13UnlockedPointsOnce2 = ES2.Load<bool>("char13Purchased");

        }

        if (ES2.Exists("char14Purchased"))
        {

            char14UnlockedPointsOnce2 = ES2.Load<bool>("char14Purchased");
        }

        if (ES2.Exists("char15Purchased"))
        {

            char15UnlockedPointsOnce2 = ES2.Load<bool>("char15Purchased");

        }

        if (ES2.Exists("char16Purchased"))
        {

            char16UnlockedPointsOnce2 = ES2.Load<bool>("char16Purchased");

        }

        if (ES2.Exists("char17Purchased"))
        {

            char17UnlockedPointsOnce2 = ES2.Load<bool>("char17Purchased");
        }

        if (ES2.Exists("char18Purchased"))
        {

            char18UnlockedPointsOnce2 = ES2.Load<bool>("char18Purchased");
        }

        if (ES2.Exists("char19Purchased"))
        {

            char19UnlockedPointsOnce2 = ES2.Load<bool>("char19Purchased");

        }

        if (ES2.Exists("char20Purchased"))
        {

            char20UnlockedPointsOnce2 = ES2.Load<bool>("char20Purchased");
        }

        if (ES2.Exists("char21Purchased"))
        {

            char21UnlockedPointsOnce2 = ES2.Load<bool>("char21Purchased");

        }

        if (ES2.Exists("char22Purchased"))
        {

            char22UnlockedPointsOnce2 = ES2.Load<bool>("char22Purchased");

        }

        if (ES2.Exists("char23Purchased"))
        {

            char23UnlockedPointsOnce2 = ES2.Load<bool>("char23Purchased");
        }

        if (ES2.Exists("char24Purchased"))
        {

            char24UnlockedPointsOnce2 = ES2.Load<bool>("char24Purchased");
        }

        if (ES2.Exists("char25Purchased"))
        {

            char25UnlockedPointsOnce2 = ES2.Load<bool>("char25Purchased");
        }

        if (ES2.Exists("char26Purchased"))
        {

            char26UnlockedPointsOnce2 = ES2.Load<bool>("char26Purchased");
        }

        if (ES2.Exists("char27Purchased"))
        {

            char27UnlockedPointsOnce2 = ES2.Load<bool>("char27Purchased");

        }

        if (ES2.Exists("char28Purchased"))
        {

            char28UnlockedPointsOnce2 = ES2.Load<bool>("char28Purchased");
        }

        if (ES2.Exists("char29Purchased"))
        {

            char29UnlockedPointsOnce2 = ES2.Load<bool>("char29Purchased");

        }




        if (
                   (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                   (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                   (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                   (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                   (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                   (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                   (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                   (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                   (!char9UnlockedPointsOnce && !char9UnlockedPointsOnce2))
        {
            timeInterval = hrumpfTimeInterval;

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) /*&&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
            (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
            (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
            (char28UnlockedPointsOnce || char28UnlockedPointsOnce2) &&
            (char29UnlockedPointsOnce || char29UnlockedPointsOnce2)*/)
        {

            allCharsUnlocked = true;
            if(!OneCharUnlockedThisGame)achiementsActivated = true;

        }

        if (OneCharUnlockedThisGame) {

            allCharsUnlocked = true;
            
        }

        //objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
        //Spawn ();

    }

    void Update()
    {
        if (OneCharUnlockedThisGame)
        {
            for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
            allCharsUnlocked = true;

            if (soundOnce)
            {
                unlockSound.Play();
                unlockSoundApplause.Play();
                soundOnce = false;
            }
        }

        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) /* &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
            (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
            (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
            (char28UnlockedPointsOnce || char28UnlockedPointsOnce2) &&
            (char29UnlockedPointsOnce || char29UnlockedPointsOnce2)*/)
        {
            UIimages.SetActive(false);
            allCharsUnlocked = true;
            

        }

       /* if (destroyOnce && (achievemntUnlockedThisGame || OneCharUnlockedThisGame)) {

            DestroyAllObjects();
            DestroyAllObjectsUnlocker();
            destroyOnce = false;

        }*/

        if (!allCharsUnlocked)
        {

            if ((numberOfPickups > origNumberOfPickups) || startTextOnce)
            {
                textPickup.text = "" + (int)numberOfPickups + "/" + (int)finalNumber + "       ";


                origNumberOfPickups = numberOfPickups;
                startTextOnce = false;
            }

        }
        else
        {

            timeInterval = 5f;

            if (achievemntUnlockedThisGame && achiementsActivated)
            {
                pickupImg.gameObject.SetActive(false);
                textPickup.text = "";
                UIimages.SetActive(false);
            }
            else if (achiementsActivated)
            {
                if (falseOnceUI) {

                    for (int i = 0; i < objHUDAchievements.Length; i++) { objHUDAchievements[i].SetActive(false); }
                    falseOnceUI = false;

                }

                
                //pickupImg.gameObject.SetActive(true);
                UIimages.SetActive(true);
                objHUDAchievements[currentChar].SetActive(true);
                
                float addOne = achievementMaxPoints[currentChar] + 1f;
                textPickup.text = numberOfPickups + "/" + addOne + "       ";


            }
            else
            {
                pickupImg.gameObject.SetActive(false);
                textPickup.text = "";
                UIimages.SetActive(false);


            }

        }

        if (achiementsActivated && numberOfPickups >= achievementMaxPoints[currentChar] + 1f)
        {

            if (soundOnce)
            {
                unlockSoundApplause.Play();
                unlockSound.Play();
                soundOnce = false;
            }
            achievemntUnlockedThisGame = true;
            DestroyAllObjects();
            popupAchievement.SetActive(true);

            ES2.Save(achievementMaxPoints[currentChar], "a" + currentChar);

        }


        if ((!allCharsUnlocked || (achiementsActivated && !achievemntUnlockedThisGame)) && spawnReady /* && (hud.playerScore >= (scoreInterval * multiplier)) */)
        {

            multiplier += 1f;
            //Spawn();
            StartCoroutine(SpawnNum(timeInterval));

            spawnReady = false;
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

        if ((!char1UnlockedPointsOnce && !char1UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 1;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char1PointsToUnlock)
            {
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char2PointsToUnlock;
                numberOfPickups = 0f;
                char1UnlockedPointsOnce = true;
                char1UnlockedPointsOnceThisGame = true;
                ES2.Save(char1UnlockedPointsOnce, "char1Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 2;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                
                objHUD[0].SetActive(true);

                finalNumber = char1PointsToUnlock;
            }

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (!char2UnlockedPointsOnce && !char2UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 2;
            ES2.Save(nextChar, "nextChar");

            if (numberOfPickups >= char2PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char3PointsToUnlock;
                numberOfPickups = 0f;
                char2UnlockedPointsOnce = true;
                char2UnlockedPointsOnceThisGame = true;
                ES2.Save(char2UnlockedPointsOnce, "char2Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 3;
                ES2.Save(nextChar, "nextChar");
            }
            else
            {
                objHUD[1].SetActive(true);
                finalNumber = char2PointsToUnlock;
            }

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (!char3UnlockedPointsOnce && !char3UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 3;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char3PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char4PointsToUnlock;
                numberOfPickups = 0f;
                char3UnlockedPointsOnce = true;
                char3UnlockedPointsOnceThisGame = true;
                ES2.Save(char3UnlockedPointsOnce, "char3Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 4;
                ES2.Save(nextChar, "nextChar");
            }
            else
            {
                objHUD[2].SetActive(true);
                finalNumber = char3PointsToUnlock;
            }

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (!char4UnlockedPointsOnce && !char4UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 4;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char4PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char5PointsToUnlock;
                numberOfPickups = 0f;
                char4UnlockedPointsOnce = true;
                char4UnlockedPointsOnceThisGame = true;
                ES2.Save(char4UnlockedPointsOnce, "char4Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 5;
                ES2.Save(nextChar, "nextChar");
            }
            else
            {
                objHUD[3].SetActive(true);
                finalNumber = char4PointsToUnlock;
            }

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (!char5UnlockedPointsOnce && !char5UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 5;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char5PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char6PointsToUnlock;
                numberOfPickups = 0f;
                char5UnlockedPointsOnce = true;
                char5UnlockedPointsOnceThisGame = true;
                ES2.Save(char5UnlockedPointsOnce, "char5Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 6;
                ES2.Save(nextChar, "nextChar");
            }
            else
            {
                objHUD[4].SetActive(true);
                finalNumber = char5PointsToUnlock;
            }

        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (!char6UnlockedPointsOnce && !char6UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 6;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char6PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char7PointsToUnlock;
                numberOfPickups = 0f;
                char6UnlockedPointsOnce = true;
                char6UnlockedPointsOnceThisGame = true;
                ES2.Save(char6UnlockedPointsOnce, "char6Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 7;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[5].SetActive(true);
                finalNumber = char6PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (!char7UnlockedPointsOnce && !char7UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 7;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char7PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char8PointsToUnlock;
                numberOfPickups = 0f;
                char7UnlockedPointsOnce = true;
                char7UnlockedPointsOnceThisGame = true;
                ES2.Save(char7UnlockedPointsOnce, "char7Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 8;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[6].SetActive(true);
                finalNumber = char7PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (!char8UnlockedPointsOnce && !char8UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 8;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char8PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char9PointsToUnlock;
                numberOfPickups = 0f;
                char8UnlockedPointsOnce = true;
                char8UnlockedPointsOnceThisGame = true;
                ES2.Save(char8UnlockedPointsOnce, "char8Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 9;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[7].SetActive(true);
                finalNumber = char8PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (!char9UnlockedPointsOnce && !char9UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 9;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char9PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                
                
                finalNumber = char10PointsToUnlock;
                numberOfPickups = 0f;
                char9UnlockedPointsOnce = true;
                char9UnlockedPointsOnceThisGame = true;
                ES2.Save(char9UnlockedPointsOnce, "char9Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 10;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[8].SetActive(true);
               
                finalNumber = char9PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (!char10UnlockedPointsOnce && !char10UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 10;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char10PointsToUnlock)
            {
                UIimages.SetActive(false);
                
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char11PointsToUnlock;
                numberOfPickups = 0f;
                char10UnlockedPointsOnce = true;
                char10UnlockedPointsOnceThisGame = true;
                ES2.Save(char10UnlockedPointsOnce, "char10Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 11;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                
                objHUD[9].SetActive(true);
                finalNumber = char10PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (!char11UnlockedPointsOnce && !char11UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 11;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char11PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char12PointsToUnlock;
                numberOfPickups = 0f;
                char11UnlockedPointsOnce = true;
                char11UnlockedPointsOnceThisGame = true;
                ES2.Save(char11UnlockedPointsOnce, "char11Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 12;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[10].SetActive(true);
                finalNumber = char11PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (!char12UnlockedPointsOnce && !char12UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 12;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char12PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char13PointsToUnlock;
                numberOfPickups = 0f;
                char12UnlockedPointsOnce = true;
                char12UnlockedPointsOnceThisGame = true;
                ES2.Save(char12UnlockedPointsOnce, "char12Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 13;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[11].SetActive(true);
                finalNumber = char12PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (!char13UnlockedPointsOnce && !char13UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 13;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char13PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char14PointsToUnlock;
                numberOfPickups = 0f;
                char13UnlockedPointsOnce = true;
                char13UnlockedPointsOnceThisGame = true;
                ES2.Save(char13UnlockedPointsOnce, "char13Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 14;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[12].SetActive(true);
                finalNumber = char13PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (!char14UnlockedPointsOnce && !char14UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 14;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char14PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char15PointsToUnlock;
                numberOfPickups = 0f;
                char14UnlockedPointsOnce = true;
                char14UnlockedPointsOnceThisGame = true;
                ES2.Save(char14UnlockedPointsOnce, "char14Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 15;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[13].SetActive(true);
                finalNumber = char14PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (!char15UnlockedPointsOnce && !char15UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 15;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char15PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char16PointsToUnlock;
                numberOfPickups = 0f;
                char15UnlockedPointsOnce = true;
                char15UnlockedPointsOnceThisGame = true;
                ES2.Save(char15UnlockedPointsOnce, "char15Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 16;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[14].SetActive(true);
                finalNumber = char15PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (!char16UnlockedPointsOnce && !char16UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 16;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char16PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char17PointsToUnlock;
                numberOfPickups = 0f;
                char16UnlockedPointsOnce = true;
                char16UnlockedPointsOnceThisGame = true;
                ES2.Save(char16UnlockedPointsOnce, "char16Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 17;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[15].SetActive(true);
                finalNumber = char16PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (!char17UnlockedPointsOnce && !char17UnlockedPointsOnce2) &&
                !allCharsUnlocked)
        {
            nextChar = 17;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char17PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char18PointsToUnlock;
                numberOfPickups = 0f;
                char17UnlockedPointsOnce = true;
                char17UnlockedPointsOnceThisGame = true;
                ES2.Save(char17UnlockedPointsOnce, "char17Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 18;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[16].SetActive(true);
                finalNumber = char17PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (!char18UnlockedPointsOnce && !char18UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 18;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char18PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char19PointsToUnlock;
                numberOfPickups = 0f;
                char18UnlockedPointsOnce = true;
                char18UnlockedPointsOnceThisGame = true;
                ES2.Save(char18UnlockedPointsOnce, "char18Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 19;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[17].SetActive(true);
                finalNumber = char18PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (!char19UnlockedPointsOnce && !char19UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 19;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char19PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char20PointsToUnlock;
                numberOfPickups = 0f;
                char19UnlockedPointsOnce = true;
                char19UnlockedPointsOnceThisGame = true;
                ES2.Save(char19UnlockedPointsOnce, "char19Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 20;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[18].SetActive(true);
                finalNumber = char19PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (!char20UnlockedPointsOnce && !char20UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 20;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char20PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char21PointsToUnlock;
                numberOfPickups = 0f;
                char20UnlockedPointsOnce = true;
                char20UnlockedPointsOnceThisGame = true;
                ES2.Save(char20UnlockedPointsOnce, "char20Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 21;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[19].SetActive(true);
                finalNumber = char20PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (!char21UnlockedPointsOnce && !char21UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 21;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char21PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char22PointsToUnlock;
                numberOfPickups = 0f;
                char21UnlockedPointsOnce = true;
                char21UnlockedPointsOnceThisGame = true;
                ES2.Save(char21UnlockedPointsOnce, "char21Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 22;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[20].SetActive(true);
                finalNumber = char21PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (!char22UnlockedPointsOnce && !char22UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 22;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char22PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char23PointsToUnlock;
                numberOfPickups = 0f;
                char22UnlockedPointsOnce = true;
                char22UnlockedPointsOnceThisGame = true;
                ES2.Save(char22UnlockedPointsOnce, "char22Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 23;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[21].SetActive(true);
                finalNumber = char22PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (!char23UnlockedPointsOnce && !char23UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 23;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char23PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char24PointsToUnlock;
                numberOfPickups = 0f;
                char23UnlockedPointsOnce = true;
                char23UnlockedPointsOnceThisGame = true;
                ES2.Save(char23UnlockedPointsOnce, "char23Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 24;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[22].SetActive(true);
                finalNumber = char23PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (!char24UnlockedPointsOnce && !char24UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 24;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char24PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char25PointsToUnlock;
                numberOfPickups = 0f;
                char24UnlockedPointsOnce = true;
                char24UnlockedPointsOnceThisGame = true;
                ES2.Save(char24UnlockedPointsOnce, "char24Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 25;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[23].SetActive(true);
                finalNumber = char24PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
          (!char25UnlockedPointsOnce && !char25UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 25;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char25PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char27PointsToUnlock;
                numberOfPickups = 0f;
                char25UnlockedPointsOnce = true;
                char25UnlockedPointsOnceThisGame = true;
                ES2.Save(char25UnlockedPointsOnce, "char25Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 26;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[24].SetActive(true);
                finalNumber = char26PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
           (!char26UnlockedPointsOnce && !char26UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 26;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char26PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char27PointsToUnlock;
                numberOfPickups = 0f;
                char26UnlockedPointsOnce = true;
                char26UnlockedPointsOnceThisGame = true;
                ES2.Save(char26UnlockedPointsOnce, "char26Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 27;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[25].SetActive(true);
                finalNumber = char26PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
            (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
           (!char27UnlockedPointsOnce && !char27UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 27;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char27PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char28PointsToUnlock;
                numberOfPickups = 0f;
                char27UnlockedPointsOnce = true;
                char27UnlockedPointsOnceThisGame = true;
                ES2.Save(char27UnlockedPointsOnce, "char27Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 28;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[26].SetActive(true);
                finalNumber = char27PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
            (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
            (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
            (!char28UnlockedPointsOnce && !char28UnlockedPointsOnce2) &&
            !allCharsUnlocked)
        {
            nextChar = 28;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char28PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = char29PointsToUnlock;
                numberOfPickups = 0f;
                char28UnlockedPointsOnce = true;
                char28UnlockedPointsOnceThisGame = true;
                ES2.Save(char28UnlockedPointsOnce, "char28Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 29;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[27].SetActive(true);
                finalNumber = char28PointsToUnlock;
            }
        }
        if ((char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
            (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
            (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
            (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
            (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
            (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
            (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
            (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
            (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
            (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
            (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
            (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
            (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
            (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
            (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
            (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
            (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
            (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
            (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
            (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
            (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
            (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
            (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
            (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
            (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
            (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
            (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
            (char28UnlockedPointsOnce || char28UnlockedPointsOnce2) &&
            (!char29UnlockedPointsOnce && !char29UnlockedPointsOnce2) 
                
            )
        {

            nextChar = 29;
            ES2.Save(nextChar, "nextChar");
            if (numberOfPickups >= char29PointsToUnlock)
            {
                UIimages.SetActive(false);
                for (int i = 0; i < objHUD.Length; i++) { objHUD[i].SetActive(false); }
                finalNumber = 30f;
                textPickup.text = " ";
                numberOfPickups = 0f;
                char29UnlockedPointsOnce = true;
                char29UnlockedPointsOnceThisGame = true;
                ES2.Save(char29UnlockedPointsOnce, "char29Unlock");
                DestroyAllObjects();
                startTextOnce = true;
                OneCharUnlockedThisGame = true;
                nextChar = 30;
                ES2.Save(nextChar, "nextChar");

            }
            else
            {
                objHUD[28].SetActive(true);
                finalNumber = char29PointsToUnlock;
            }
        }

    }


    IEnumerator SpawnNum(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);

        Spawn();

        spawnReady = true;

        destroyOnce = true;
    }

    public void Spawn()
    {


        if (!allCharsUnlocked && spawnEnabled)
        {
            if ((!char1UnlockedPointsOnce && !char1UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[0], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 1 spawn");

            }
            else if (
              (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
              (!char2UnlockedPointsOnce && !char2UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[1], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 2 spawn");
            }
            else if (
               (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
               (!char3UnlockedPointsOnce && !char3UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[2], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 3 spawn");
            }
            else if (
               (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
               (!char4UnlockedPointsOnce && !char4UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[3], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 4 spawn");
            }
            else if (
               (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
               (!char5UnlockedPointsOnce && !char5UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[4], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 5 spawn");
            }
            else if (
               (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
               (!char6UnlockedPointsOnce && !char6UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[5], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                Debug.Log("p 6 spawn");
            }
            else if (
              (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
               (!char7UnlockedPointsOnce && !char7UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[6], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [6], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 7 spawn");
            }
            else if (
               (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
               (!char8UnlockedPointsOnce && !char8UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 8 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (!char9UnlockedPointsOnce && !char9UnlockedPointsOnce2))
            {
                //timeInterval = 0.5f;
                if (spawnEnabled) Instantiate(obj[8], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 9 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (!char10UnlockedPointsOnce && !char10UnlockedPointsOnce2))
            {

                if (spawnEnabled) Instantiate(obj[9], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 10 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (!char11UnlockedPointsOnce && !char11UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[10], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 11 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (!char12UnlockedPointsOnce && !char12UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[11], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 12 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (!char13UnlockedPointsOnce && !char13UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[12], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 13 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                 (!char14UnlockedPointsOnce && !char14UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[13], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 14 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                 (!char15UnlockedPointsOnce && !char15UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[14], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 15 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                 (!char16UnlockedPointsOnce && !char16UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[15], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 16 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                 (!char17UnlockedPointsOnce && !char17UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[16], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 17 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                 (!char18UnlockedPointsOnce && !char18UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[17], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 18 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                 (!char19UnlockedPointsOnce && !char19UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[18], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 19 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                 (!char20UnlockedPointsOnce && !char20UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[19], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 20 spawn");
            }
            else if (
                (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                 (!char21UnlockedPointsOnce && !char21UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[20], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 21 spawn");
            }
            else if (
                   (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                 (!char22UnlockedPointsOnce && !char22UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[21], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 22 spawn");
            }
            else if (
                  (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                 (!char23UnlockedPointsOnce && !char23UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[22], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 23 spawn");
            }
            else if (
                  (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                 (!char24UnlockedPointsOnce && !char24UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[23], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 24 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
                 (!char25UnlockedPointsOnce && !char25UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[24], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 25 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
                (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
                 (!char26UnlockedPointsOnce && !char26UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[25], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 26 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
                (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
                (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
                 (!char27UnlockedPointsOnce && !char27UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[26], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 27 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
                (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
                (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
                (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
                 (!char28UnlockedPointsOnce && !char28UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[27], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 28 spawn");
            }
            else if (
                 (char1UnlockedPointsOnce || char1UnlockedPointsOnce2) &&
                (char2UnlockedPointsOnce || char2UnlockedPointsOnce2) &&
                (char3UnlockedPointsOnce || char3UnlockedPointsOnce2) &&
                (char4UnlockedPointsOnce || char4UnlockedPointsOnce2) &&
                (char5UnlockedPointsOnce || char5UnlockedPointsOnce2) &&
                (char6UnlockedPointsOnce || char6UnlockedPointsOnce2) &&
                (char7UnlockedPointsOnce || char7UnlockedPointsOnce2) &&
                (char8UnlockedPointsOnce || char8UnlockedPointsOnce2) &&
                (char9UnlockedPointsOnce || char9UnlockedPointsOnce2) &&
                (char10UnlockedPointsOnce || char10UnlockedPointsOnce2) &&
                (char11UnlockedPointsOnce || char11UnlockedPointsOnce2) &&
                (char12UnlockedPointsOnce || char12UnlockedPointsOnce2) &&
                (char13UnlockedPointsOnce || char13UnlockedPointsOnce2) &&
                (char14UnlockedPointsOnce || char14UnlockedPointsOnce2) &&
                (char15UnlockedPointsOnce || char15UnlockedPointsOnce2) &&
                (char16UnlockedPointsOnce || char16UnlockedPointsOnce2) &&
                (char17UnlockedPointsOnce || char17UnlockedPointsOnce2) &&
                (char18UnlockedPointsOnce || char18UnlockedPointsOnce2) &&
                (char19UnlockedPointsOnce || char19UnlockedPointsOnce2) &&
                (char20UnlockedPointsOnce || char20UnlockedPointsOnce2) &&
                (char21UnlockedPointsOnce || char21UnlockedPointsOnce2) &&
                (char22UnlockedPointsOnce || char22UnlockedPointsOnce2) &&
                (char23UnlockedPointsOnce || char23UnlockedPointsOnce2) &&
                (char24UnlockedPointsOnce || char24UnlockedPointsOnce2) &&
                (char25UnlockedPointsOnce || char25UnlockedPointsOnce2) &&
                (char26UnlockedPointsOnce || char26UnlockedPointsOnce2) &&
                (char27UnlockedPointsOnce || char27UnlockedPointsOnce2) &&
                (char28UnlockedPointsOnce || char28UnlockedPointsOnce2) &&
                 (!char29UnlockedPointsOnce && !char29UnlockedPointsOnce2))
            {
                if (spawnEnabled) Instantiate(obj[28], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
                //Instantiate (obj [7], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + 5.5f), transform.position.z), Quaternion.identity);
                Debug.Log("p 29 spawn");
            }



        }
        else if (achiementsActivated && !achievemntUnlockedThisGame)
        {



            if (spawnEnabled) Instantiate(objAchievements[currentChar], new Vector3(transform.position.x, Random.Range(transform.position.y, transform.position.y + maxSpawnHeight), transform.position.z), Quaternion.identity);
            Debug.Log("a " + currentChar + " spawn");




        }
        else {

            DestroyAllObjectsUnlocker();
            DestroyAllObjects();


        }


    }





}