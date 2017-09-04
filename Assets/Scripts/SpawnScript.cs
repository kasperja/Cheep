using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	private float spawnMinTwo = 1f;
	private float spawnMaxTwo = 2f;
	public PlatformerCharacter2D pc2D;
	private bool spawnReady = false;
	private bool spawnReadyOnce = true;
	private bool coOnce = true;
	public bool spawnBoundsR = false;
	private bool spawnReadyFront = false;
	public bool spawnRocketDisable = false;
	public bool isFG = false;
    public bool isSuper = false;
    public bool isBoss = false;
    public bool isNorm = false;
    public bool isFirstStart = false;
    public GroundNearUniversal gUni;
    private bool isUpdate = false;
    public bool hasExited = false;
    public bool hasExitedOnce = false;

    public bool CRrunning = false;
    public bool runOnce = true;
    public bool isEmpty = false;

    public bool isMG = false;

    public int counter = 0;
	//public ObjectPoolManager objm;
	// Use this for initialization
	void Start () {
        isFirstStart = false;

        //objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
        //Spawn ();
        spawnReadyOnce = true;
       // StartCoroutine(waitStart());

    }

    void Update() {

        if (true)
        {
        
            spawnMinTwo = (16 / pc2D.m_MaxSpeed) * spawnMin;
            spawnMaxTwo = (16 / pc2D.m_MaxSpeed) * spawnMax;


        }
        else {
            spawnMinTwo = spawnMin;
            spawnMaxTwo = spawnMax;


        }
		if (spawnReady && spawnReadyOnce && spawnBoundsR) {
            Debug.Log("Weeeee");
            //StartCoroutine(waitToBeSure());
            spawnReadyOnce = false;
        }

        if (hasExited && hasExitedOnce) {

           // StartCoroutine(waitToBeSureTwo());
            hasExitedOnce = false;
        }

        if (!CRrunning && hasExited && runOnce && counter == 0) {

            StartCoroutine(waitToBeSureTwo());
            runOnce = false;
        }

        if (isMG && runOnce && !CRrunning)
        {

            StartCoroutine(waitToBeSureTwo());
            runOnce = false;
        }

    }
	void OnEnable(){

        // Debug.Log("Weeeee");
        StopAllCoroutines();
        CRrunning = false;
        runOnce = true;
       // hasExited = true;
        

       // if (isBoss && gUni.spawnReady) Spawn();

        if (!isFirstStart)
        {
         //  StartCoroutine(waitStart());
            //Spawn();

        }
        else {
            Spawn();
            
            isFirstStart = false;
            

        }
		coOnce = true;
        //spawnReadyOnce = true;
        


    }
	void OnDisable(){
        // Debug.Log("Weeeee2");
        runOnce = false;
        StopAllCoroutines();
        CRrunning = false;
        
		//CancelInvoke ("Spawn");
	
	}
	public void Spawn(){
		if (isFG) {
			if (spawnBoundsR && spawnReadyFront && !spawnRocketDisable)
				Instantiate (obj [Random.Range (0, obj.Length)], new Vector3(transform.position.x, Random.Range(transform.position.y+1f, transform.position.y -1.2f),transform.position.z), Quaternion.identity);
		}else{
            if (spawnBoundsR && spawnReadyFront && !spawnRocketDisable && counter == 0)
            {

                StartCoroutine(waitToBeSureTwo());
            }

		//objm.Acquire (obj[Random.Range(0, obj.Length)].GetComponent<StringName>().nameString, transform.position, Quaternion.identity);
		}
		spawnReadyFront = true;

        //StartCoroutine(waitStart());

	/*	if (coOnce) {
			StartCoroutine (waitStart ());
			coOnce = false;
		}

        if (spawnReady && !isNorm)
        {
            StartCoroutine(waitStart());
            Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));

        }
        else {

           StartCoroutine(waitStart());

        }

        if (isNorm) {

            StartCoroutine(waitStart());

        }*/

    }

	IEnumerator waitStart(){

        yield return new WaitForSeconds(Random.Range(spawnMinTwo, spawnMaxTwo));
        Spawn();
        
        /*
        if (isBoss)
        {
            yield return new WaitForSeconds(Random.Range(0f, 0f));
            Spawn();
        }
        else if (isNorm)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
            Spawn();
        }
        else {

            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
            Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));
        }*/
		//spawnReady = true;
       // spawnReadyOnce = true;

        if(!isUpdate)StartCoroutine(waitStart());
        isUpdate = false;


    }
    IEnumerator waitToBeSure() {

        
        if (isBoss)
        {
            yield return new WaitForSeconds(0.0f);
        }
        else {
            yield return new WaitForSeconds(0.2f);
        }
        if (spawnBoundsR) { 
            //isUpdate = true;
            //StartCoroutine(waitStart());
            Spawn();
        //Invoke("Spawn", Random.Range(spawnMinTwo, spawnMaxTwo));
            spawnReadyOnce = false;
        }
        yield return new WaitForSeconds(0.2f);
       // spawnReadyOnce = true;

    }

    public IEnumerator waitToBeSureTwo()
    {
        CRrunning = true;

        if (isBoss)
        {
            yield return new WaitForSeconds(0.0f);
        }
        else
        {
            yield return new WaitForSeconds(Random.Range(spawnMin, spawnMax));
        }
        if (counter == 0)
        {
            if (isSuper)
            {
                Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(transform.position.x, Random.Range(transform.position.y - 3f, transform.position.y), transform.position.z), Quaternion.identity);
            }
            else
            {
                Debug.Log("YO!");
                Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
            }

        }
        else if(isMG){

            //yield return new WaitForSeconds(1f);
            //StartCoroutine(waitToBeSureTwo());
            Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);

        }
        //yield return new WaitForSeconds(0.2f);
        // spawnReadyOnce = true;
        runOnce = true;
        CRrunning = false;
    }

}
