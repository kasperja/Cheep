using UnityEngine;
using System.Collections;


public class LavineMove : MonoBehaviour {

	public Transform beginPos;
	public Transform endPos;
	public Transform endPosDeath;

    public GroundNearUniversal groundNearUniversal;

	private float speed = 5f;

	public bool isRolling = false;

	private bool rollOnce = true;

	public PlatformerCharacter2D pc2D;

	public int touchCounter = 0;

	public GameObject normSpawn;
	public GameObject bossSpawn;
	public GameObject powerUpSpawn;
	public GameObject powerUpSuperSpawn;
	public GameObject powerUpTopSpawn;

	public bool deactivateOnce = true;

	public bool spamActive = false;

	public bool isReady = false;
	private bool readyOnce = true;

	public DestroyerScript destroyBot;

	public bool isDeadByLavine = false;

	public bool lavineTest = false;

	public AudioSource lavineSoundLoop;
	public float randomSoundFloat = 0f;

	public ParticleSystem lavineDeathParticle;

	public float tTap = 0f;
	public GameObject tapTapObj;
	public GameObject feedbackTextObj;

	private Color colFeedbackText;

	public bool tapTapReady = false;

	private bool slowMotionBool = false;
	private float timeScaler = 1f;

	public bool isRocket = false;

	private bool rocketOnce = true;

	public bool isLavine = false;
	public bool isSnowball = false;
	public bool isYeti = true;

	public GameObject lavineObj;
	public GameObject snowballObj;
	public GameObject yetiObj;

	public Animator snowBallAnimator;

	private float randomBoss = 1f;

	public bool randomBossEnabled = false;

	public bool dangerOver = false;

	public bool boss1Unlocked = true;
	public bool boss2Unlocked = false;
	public bool boss3Unlocked = false;

	public bool A = true;

	public bool AB = false;
	public bool BA = false;

	public bool ABC = false;
	public bool ACB = false;
	public bool BAC = false;
	public bool BCA = false;
	public bool CAB = false;
	public bool CBA = false;

	//public bool[] arrayOrder = new bool[]{false, false, false, false, false, false};

	public int bossCount = 1;

	private Vector3 lavineEndPosOrig;

	public DontDestroyTwo musicScript;

    public AudioSource yetiSound;

    public GameObject powerUpObj;
    public GameObject superObj;
    public GameObject unlockerObj;
    public SpawnScriptUnlocker unlockerScript;
    private bool destroyOnce = true;
    

	// Use this for initialization
	void Start () {



		musicScript = GameObject.Find ("Music").GetComponent<DontDestroyTwo> ();

		lavineEndPosOrig = endPos.transform.localPosition;

		if (ES2.Exists ("boss1Unlocked")) {

			boss1Unlocked =  ES2.Load<bool>( "boss1Unlocked");
		}
		if (ES2.Exists ("boss2Unlocked")) {

			boss2Unlocked =  ES2.Load<bool>( "boss2Unlocked");
		}
		if (ES2.Exists ("boss3Unlocked")) {

			boss3Unlocked =  ES2.Load<bool>( "boss3Unlocked");

		}

		randomBoss = Random.Range (0f, 6f);

       

        if (randomBossEnabled && boss1Unlocked && boss2Unlocked && boss3Unlocked) {

			if (randomBoss >= 0f && randomBoss < 1f) {
				
				lavineObj.SetActive (true);
				snowballObj.SetActive (false);
				yetiObj.SetActive (false);

				isLavine = true;
				isSnowball = false;
				isYeti = false;


				ABC = true;
			
			} else if (randomBoss >= 1f && randomBoss < 2f) {
			
				lavineObj.SetActive (true);
				snowballObj.SetActive (false);
				yetiObj.SetActive (false);

				isLavine = true;
				isSnowball = false;
				isYeti = false;

				ACB = true;
			
			} else if (randomBoss >= 2f && randomBoss < 3f) {
			
				lavineObj.SetActive (false);
				snowballObj.SetActive (true);
				yetiObj.SetActive (false);

				isLavine = false;
				isSnowball = true;
				isYeti = false;


				BAC = true;
			
			} else if (randomBoss >= 3f && randomBoss < 4f) {
			
				lavineObj.SetActive (false);
				snowballObj.SetActive (true);
				yetiObj.SetActive (false);

				isLavine = false;
				isSnowball = true;
				isYeti = false;


				BCA = true;
			
			} else if (randomBoss >= 4f && randomBoss < 5f) {

				lavineObj.SetActive (false);
				snowballObj.SetActive (false);
				yetiObj.SetActive (true);

				isLavine = false;
				isSnowball = false;
				isYeti = true;

				CAB = true;

			} else if (randomBoss >= 5f && randomBoss < 6f) {
			
				lavineObj.SetActive (false);
				snowballObj.SetActive (false);
				yetiObj.SetActive (true);

				isLavine = false;
				isSnowball = false;
				isYeti = true;

				CBA = true;

			}
		} else if (randomBossEnabled && boss1Unlocked && boss2Unlocked) {
		

			if (randomBoss >= 0f && randomBoss < 3f) {

				lavineObj.SetActive (true);
				snowballObj.SetActive (false);
				yetiObj.SetActive (false);

				isLavine = true;
				isSnowball = false;
				isYeti = false;

				//ABC = true;
				AB = true;

			} else if (randomBoss >= 3f && randomBoss < 6f) {

				lavineObj.SetActive (false);
				snowballObj.SetActive (true);
				yetiObj.SetActive (false);

				isLavine = false;
				isSnowball = true;
				isYeti = false;

				//ABC = true;
				BA = true;


			}

		
		} else if (randomBossEnabled && boss1Unlocked) {

			lavineObj.SetActive (true);
			snowballObj.SetActive (false);
			yetiObj.SetActive (false);

			isLavine = true;
			isSnowball = false;
			isYeti = false;

			//ABC = true;

		}

		colFeedbackText = feedbackTextObj.GetComponent<TextMesh> ().color;
		//feedbackTextObj.GetComponent<TextMesh> ().color = new Color (1f,1f,1f, 1f);


		transform.localPosition = beginPos.localPosition;
		StartCoroutine (setRollingTrue ());

	}

	// Update is called once per frame
	void Update () {
		randomSoundFloat = Random.Range (0f,1f);
		/*if (Input.GetKeyDown (KeyCode.Space) || Input.GetTouch (0).phase == TouchPhase.Began) {
		
			touchCounter += 1;
	
		
		}*/

		if (rocketOnce) {
		
			//StartCoroutine (setRollingTrue ());
			rocketOnce = false;
		
		}

		if (pc2D.isRocket) {
		

			rocketOnce = true;
			bossSpawn.SetActive (false);
			normSpawn.SetActive (true);

		
		} else {
		
			//plusTxt.SetActive (true);
		
		}

		//Time.timeScale = timeScaler;

		if (slowMotionBool && !isRocket) {
		
			if(timeScaler > 0.5f) timeScaler -= 1f * Time.deltaTime;

		} else {
		
			if(timeScaler < 1f) timeScaler += 1f * Time.deltaTime;
		
		}

		if (isDeadByLavine) {
			
			transform.position += new Vector3 (10f, 0, 0) * Time.deltaTime;
		
		}

		if(transform.position.x <= beginPos.position.x) {
			
			transform.position = new Vector3(beginPos.position.x , beginPos.position.y, transform.position.z);
		
		}

		speed = pc2D.m_MaxSpeed;

		/*
		if (transform.position.x > beginPos.position.x && !isDeadByLavine && Time.timeScale > 1f) {
			if (speed < 9f) {

				transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

			} else if(!isDeadByLavine){

				transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);

			}

		}else */

		if (isRolling) {

            
            //unlockerScript.DestroyAllObjectsSuper();
            //unlockerScript.DestroyAllObjectsNorm();
            //powerUpObj.SetActive(false);
            //superObj.SetActive(false);
            //unlockerObj.SetActive(false);
            



            musicScript.isRollingMusic = true;

			pc2D.boostActivate = true;

			if (tapTapReady) {
				
				if (tTap < 10f)
					tTap += 1f * Time.deltaTime;

				if (tTap < 0.5f) {

					tapTapObj.SetActive (false);
				
				} else {
				
					tapTapObj.SetActive (true);

				
				}
			} else {
			
				tapTapObj.SetActive (false);
			
			}

            if (lavineSoundLoop.volume < 1f && !isYeti)
            {
                lavineSoundLoop.volume += 1f * Time.deltaTime;

            }
            else if(isYeti){


                lavineSoundLoop.volume -= 1f * Time.deltaTime;
            }

			if (pc2D.isDead) {


				//transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;

			}


			if (touchCounter >= 15) {
				
				deactivateOnce = true;
				isRolling = false;

			
			}




			if (transform.position.x < endPos.position.x) {
				if (speed < 9f && !pc2D.isDead) {

					transform.position += new Vector3 (10f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed / 200f * 2f * Time.deltaTime);

				} else if (!pc2D.isDead) {

					transform.position += new Vector3 (10f, 0, 0) * Time.deltaTime;
					//	transform.position = Vector3.MoveTowards (transform.position, endPos.position, speed * 200f * Time.deltaTime);

				} 
				
			}
            if (rollOnce && !pc2D.isDead) {
                unlockerScript.spawnEnabled = false;
                unlockerScript.DestroyAllObjectsUnlocker();
                unlockerScript.DestroyAllObjects();
                

                lavineSoundLoop.Play();
                if (randomBossEnabled) {

						if (bossCount == 1) {


							if (ABC) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;


						
							} else if (ACB) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;


						
							} else if (BAC) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;



							} else if (BCA) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;


						
							} else if (CAB) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;


						
							} else if (CBA) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;


						
							} else if (AB) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;

							} else if (BA) {
						
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;
						
							}
						} else if (bossCount == 2) {

							if (!boss2Unlocked)
								AB = true;



							if (ABC) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;



							} else if (ACB) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;



							} else if (BAC) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;



							} else if (BCA) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;



							} else if (CAB) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;



							} else if (CBA) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;



							} else if (AB) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;

							} else if (BA) {

								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;

							}
						} else if (bossCount == 3) {

							if ((AB || BA) && !boss3Unlocked) {
						
								ABC = true;
						
							}

							if (ABC) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;



							} else if (ACB) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;



							} else if (BAC) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;



							} else if (BCA) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;



							} else if (CAB) {
								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;



							} else if (CBA) {
								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;



							} /*else if (AB || BA) {

							randomBoss = Random.Range (1f, 6f);

							if (randomBoss >= 0f && randomBoss < 3f) {

								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;




							} else if (randomBoss >= 3f && randomBoss < 6f) {

								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;




							}
				
						}*/
						} else if (bossCount > 3) {
						

							randomBoss = Random.Range (0f, 6f);
							if (randomBoss >= 0f && randomBoss < 1f) {

								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;




							} else if (randomBoss >= 1f && randomBoss < 2f) {

								lavineObj.SetActive (true);
								snowballObj.SetActive (false);
								yetiObj.SetActive (false);

								isLavine = true;
								isSnowball = false;
								isYeti = false;




							} else if (randomBoss >= 2f && randomBoss < 3f) {

								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;




							} else if (randomBoss >= 3f && randomBoss < 4f) {

								lavineObj.SetActive (false);
								snowballObj.SetActive (true);
								yetiObj.SetActive (false);

								isLavine = false;
								isSnowball = true;
								isYeti = false;




							} else if (randomBoss >= 4f && randomBoss < 5f) {

								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;




							} else if (randomBoss >= 5f && randomBoss < 6f) {

								lavineObj.SetActive (false);
								snowballObj.SetActive (false);
								yetiObj.SetActive (true);

								isLavine = false;
								isSnowball = false;
								isYeti = true;




							}

						}
						if (bossCount == 2) {
					
							boss2Unlocked = true;
							ES2.Save (boss2Unlocked, "boss2Unlocked");
					
						}

						if (bossCount == 3) {

							boss3Unlocked = true;
							ES2.Save (boss3Unlocked, "boss3Unlocked");

						}

						bossCount += 1;
					}

					if (isSnowball) {
					
						snowBallAnimator.SetBool ("isRolling", true);

					}
					StartCoroutine (waitDeath ());
					StartCoroutine (vibrateNum ());

					//StartCoroutine (waitForRoll ());
					//bossSpawn.SetActive (true);
					//normSpawn.SetActive (false);
				
					//deactivateOnce = true;
					//pc2D.DestroyAllObjects ();
					powerUpSpawn.SetActive (false);
					powerUpSuperSpawn.SetActive (false);
					powerUpTopSpawn.SetActive (false);
					rollOnce = false;

				}
			

			//feedbackTextObj.GetComponent<TextMesh> ().color = colFeedbackText;
			
		} else {

            powerUpObj.SetActive(true);
            superObj.SetActive(true);
            //unlockerObj.SetActive(true);
            

            musicScript.isRollingMusic = false;

			tapTapObj.SetActive (false);

			if(lavineSoundLoop.volume >= 0f)lavineSoundLoop.volume -= 0.5f * Time.deltaTime;

            if (lavineSoundLoop.volume <= 0f) lavineSoundLoop.Stop();

			if (deactivateOnce && !pc2D.isDead && !isDeadByLavine) {

				snowBallAnimator.SetBool ("isRolling", false);

				endPos.transform.localPosition = lavineEndPosOrig;

				isRolling = false;
				pc2D.boostActivate = false;
				slowMotionBool = true;
				pc2D.feedbackTap = true;
                //Debug.Log ("deactivated");
#if UNITY_IOS
        Handheld.Vibrate();
#endif
#if UNITY_ANDROID
                Handheld.Vibrate();
#endif
                powerUpSpawn.SetActive (true);
				powerUpSuperSpawn.SetActive (true);
				powerUpTopSpawn.SetActive (true);
				
				
				spamActive = false;
				//isReady = false;
				StartCoroutine (setRollingTrue ());
				deactivateOnce = false;

				musicScript.dangerOnce = true;



			}

			touchCounter = 0;
			if (transform.position.x > beginPos.position.x && !isDeadByLavine) {
				if (speed < 9f) {
				
					transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, endPosDeath.position, speed * 2f * Time.deltaTime);

				} else if(!isDeadByLavine){

					transform.position -= new Vector3 (5f, 0, 0) * Time.deltaTime;
					//transform.position = Vector3.MoveTowards (transform.position, beginPos.position, speed * Time.deltaTime);

				}

			}
		}
		

		if (pc2D.isDead) {
		
			//if(pc2D.m_MaxSpeed > 0f) speed -= 10000.8f * Time.deltaTime;
		
		}


	}

	IEnumerator waitForRoll(){
		
		//deactivateOnce = true;
		
		normSpawn.SetActive (false);
        bossSpawn.SetActive(true);
        if (!groundNearUniversal.spawnReady)
        {

            yield return new WaitForSeconds(0.5f);
            

        }
        else {

            yield return new WaitForSeconds(0.5f);

        }

        
        //if (yetiObj.activeSelf) yetiSound.Play();
        yield return new WaitForSeconds (6f);


		isRolling = true;
        


		yield return new WaitForSeconds (1.5f);
        if (yetiObj.activeSelf) yetiSound.Play();

        spamActive = true;

		tapTapReady = true;

#if UNITY_IOS
        Handheld.Vibrate();
#endif
#if UNITY_ANDROID
        Handheld.Vibrate();
#endif
        deactivateOnce = true;
		//yield return new WaitForSeconds (Random.Range(25f,35f));
		//rollOnce = true;
		//isRolling = true;



	}

	IEnumerator waitDeath (){
		
		yield return new WaitForSeconds (8f);
		if (isRolling) {

			tapTapReady = false;

			StartCoroutine (waitDeathFinal ());


			isDeadByLavine = true;
		}
	
	}
	IEnumerator waitDeathFinal(){
		
		lavineDeathParticle.Play ();
		yield return new WaitForSeconds (0.5f);

		tapTapReady = false;
        
        destroyBot.dieBool = true;
		lavineDeathParticle.Play ();
#if UNITY_IOS
        Handheld.Vibrate();
#endif
#if UNITY_ANDROID
        Handheld.Vibrate();
#endif


    }
    /*IEnumerator waitForRollStart(){

		//deactivateOnce = true;
		yield return new WaitForSeconds (Random.Range(25f,30f));





		bossSpawn.SetActive (true);
		normSpawn.SetActive (false);

		yield return new WaitForSeconds (8f);


		isRolling = true;


		yield return new WaitForSeconds (2f);

		spamActive = true;


		//yield return new WaitForSeconds (Random.Range(25f,35f));
		//rollOnce = true;
		//isRolling = true;



	}*/
    IEnumerator vibrateNum(){


		yield return new WaitForSeconds (0.6f);

#if UNITY_IOS
        Handheld.Vibrate();
#endif
#if UNITY_ANDROID
        Handheld.Vibrate();
#endif



        //if(isRolling)StartCoroutine (vibrateNum ());

    }

    IEnumerator setRollingTrue(){

		tapTapReady = false;

		pc2D.feedbackOnce = true;
		pc2D.feedbackOnceTwo = true;
        yield return new WaitForSeconds(0.0f);

        normSpawn.SetActive(true);
        unlockerScript.spawnEnabled = true;
        yield return new WaitForSeconds(0.2f);
        bossSpawn.SetActive(false);
        yield return new WaitForSeconds (2.4f);
        

        slowMotionBool = false;
		yield return new WaitForSeconds (0f);
        
        dangerOver = false;
		//feedbackTextObj.GetComponent<TextMesh> ().color = new Color (1f,1f,1f, 1f);


		if (lavineTest) {
			yield return new WaitForSeconds (0f);
		} else {
			yield return new WaitForSeconds (Random.Range (20f, 25f));
		}



		rollOnce = true;



		StartCoroutine (waitForRoll ());

		
			
			
			
		//deactivateOnce = true;
		




		
	
	}



}
