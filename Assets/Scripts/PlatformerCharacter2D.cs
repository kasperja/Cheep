using System;
using UnityEngine;
using System.Collections;

//namespace UnityStandardAssets._2D
//{
    public class PlatformerCharacter2D : MonoBehaviour
    {

        [SerializeField] public float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
        [SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.
        [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // Amount of maxSpeed applied to crouching movement. 1 = 100%
        [SerializeField] private bool m_AirControl = false;                 // Whether or not a player can steer while jumping;
        [SerializeField] private LayerMask m_WhatIsGround;                  // A mask determining what is ground to the character


    public float shakeMagnitude = 2f;
    public float shakeRoughness = 5f;
        public float shakeFadeIn = 0.1f;
    public float shakeFadeOut = 1f;

        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        public bool m_Grounded;            // Whether or not the player is grounded.
        private Transform m_CeilingCheck;   // A position marking where to check for ceilings
        const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
        private bool m_FacingRight = true;  // For determining which way the player is currently facing.

		public ParticleSystem bumpParticle;
		private bool playOnce = true;

		public bool isDead = false;
		public AudioSource jumpSound;
		public AudioSource jumpSoundTwo;
		public AudioSource jumpSoundThree;
		public AudioSource hitSound;

    public AudioSource doubleJumpSound;
    public AudioSource doubleJumpSoundTwo;
    public AudioSource doubleJumpSoundThree;

    bool doubleJump = false;

		public GameObject mainCam;

		public ParticleSystem trailParticle;
		private float randomFloat = 0f;
	public bool scream1 = true;
	public bool scream2 = true;
	public bool scream3 = true;

	private bool shiftAnimOnce = true;

	public SpawnScript groundSpawnScript;

	public HUDScript hudScriptPoints;

	private float origAmmount;

	public bool boostActivate = false;

	public GameObject groundSpawnNorm;
	public GameObject groundSpawnBoss;

	public float boostOrig = 20f;

	private float acceleration = 4f;

	public bool decreaseSpeed = true;

	private GameObject[] gameObjects;

	public AudioSource landingSnow;
    public AudioSource landingSnowTwo;
    public AudioSource landingSnowThree;
    private bool landOnce = true;

	private float animationSpeed = 1f;
	private float animationMaxSpeed = 1.6f;

	public FadeOut fadeOutScript;

	public AudioSource skiingSound;

	public AudioSource obstacleAvoided;
	public AudioSource obstacleAvoidedTwo;
	public AudioSource obstacleAvoidedThree;
	public Animator feedbackAnimator;
	public MeshRenderer feedbackMesh;
	public TextMesh feedbackText;
    public AudioSource applauseSound;
    public AudioSource applauseSoundTwo;
    public AudioSource applauseSoundThree;

    public bool feedbackTap = false;
	public bool feedbackOnce = true;
	public bool feedbackOnceTwo = true;

	public bool groundOnce = true;

	public bool airActive = false;

	public DestroyerScript destroyerScript;

	public bool speedDeathOnce = true;

	public bool isRocket = false;
	private bool isRocketOnce = true;
	public GameObject alwaysGround;
	public ParticleSystem rocketParticle;

	public RotateCam rCam;
	public GameObject feedBackTxt;

	public ShaderVariantCollection preloadedShaders;

	public SpawnScript rocketSpawn;
	public bool rocketActivate = false;
	public float jumpCount = 0f;

	public CameraBoxFollow cbf;
	public bool pickupFeedBack = false;

        private void Awake()
        {
        Resources.UnloadUnusedAssets();
			//Resources.LoadAll ("Textures");
			//Resources.LoadAll ("Sound");
			//Resources.LoadAll ("Prefabs");

			//preloadedShaders.WarmUp ();

			Application.targetFrameRate = 60;
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_CeilingCheck = transform.Find("CeilingCheck");
            m_Anim = GetComponent<Animator>();
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }

	public void DestroyAllObjects()
	{
		gameObjects = GameObject.FindGameObjectsWithTag ("Obstacle");

		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
		}
	}

	public void DisableAllObjects()
	{
		gameObjects = GameObject.FindGameObjectsWithTag ("Obstacle");

		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			gameObjects [i].GetComponent<BoxCollider2D> ().isTrigger = true;
		}
	}

	void Start(){

		ES2.Save (1, "prevScene");

		feedbackMesh.gameObject.SetActive (false);
		origAmmount = hudScriptPoints.scoreOverTimeAmmount;

	}

		void Update(){

		if (transform.position.y < -4.5f) {
		
			cbf.belowGround = true;
		
		} else {
		

			cbf.belowGround = false;
		
		}

		if (!boostActivate) {
			if (!isDead) {
				if (m_MaxSpeed > 17f)
					m_MaxSpeed -= 20f * Time.deltaTime;
			}

		}
		if (gameObject.GetComponent<Rigidbody2D>().velocity.x < 8f && speedDeathOnce) {
		
			StartCoroutine (waitDeathOfSpeed ());

			speedDeathOnce = false;
		
		}

		/*if (!m_Grounded && groundOnce) {
		
			StartCoroutine (waitGround ());

			groundOnce = false;
		
		}*/

		if (isRocket) {

			rocketSpawn.spawnRocketDisable = true;

			if (isRocketOnce) {



				rocketParticle.Play ();

				StartCoroutine (waitRocket());

				isRocketOnce = false;

			}

			alwaysGround.SetActive (true);
			//if (Time.timeScale < 4f && rocketActivate)
				//Time.timeScale += 1f * Time.deltaTime;
		
		} else {
			rocketSpawn.spawnRocketDisable = false;

			//if (Time.timeScale > 1f)
				//Time.timeScale -= 0.5f *Time.deltaTime;
		
		}

		if (!isRocket) {
			alwaysGround.SetActive (false);
			rocketParticle.Stop ();
		}

		if(feedbackTap && feedbackOnce){
			
			if(!isRocket)feedbackMesh.gameObject.SetActive (true);
           


            if (randomFloat < 1f) {

                applauseSoundTwo.Play();
                feedbackText.text = "Great!";
				obstacleAvoidedTwo.Play();

			} else if (randomFloat >= 1f && randomFloat < 2f) {
                applauseSoundThree.Play();

                feedbackText.text = "Awesome!";
				obstacleAvoidedThree.Play();

			} else {

                applauseSound.Play();
                feedbackText.text = "Nice!";
				obstacleAvoided.Play();

			}

			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();


			feedbackMesh.enabled = true;
			feedbackAnimator.SetBool ("Avoided", true);
			StartCoroutine (waitFeedback ());
            //  particleHit.Play();
            
            feedbackOnce = false;
            

			if (feedbackOnceTwo) {
			
				StartCoroutine (waitFeedbackTwo ());

				feedbackOnceTwo = false;
			
			}

		}



		if (animationSpeed <= animationMaxSpeed && !decreaseSpeed) {
		
			animationSpeed += 0.2f * Time.deltaTime;
		
		} else if (animationSpeed > 1f && decreaseSpeed) {
		
			animationSpeed -= 0.2f * Time.deltaTime;
		
		}


		if (m_Grounded) {

			jumpCount = 0f;
			
			m_Anim.speed = animationSpeed;
		
		} else {
		
			skiingSound.Stop ();
			m_Anim.speed = 1f;
		
		}


		if (m_Grounded && landOnce) {
		
            

                if (randomFloat < 1f)
                {

                    landingSnow.Play();



                }
                else if (randomFloat >= 1f && randomFloat < 2f)
                {

                landingSnowTwo.Play();



                }
                else
                {

                landingSnowThree.Play();



                }
            

			trailParticle.Play ();
            //EZCameraShake.CameraShaker.Instance.ShakeOnce(shakeMagnitude, shakeRoughness, shakeFadeIn, shakeFadeOut);
            landOnce = false;
		
		}

		/*if (boostActivate) {
		
			DestroyAllObjects ();

			groundSpawnBoss.SetActive (true);
			groundSpawnNorm.SetActive (false);
		
		
		} else {
			
			groundSpawnBoss.SetActive (false);
			groundSpawnNorm.SetActive (true);
		
		
		
		}*/
	
		
		randomFloat = UnityEngine.Random.Range(0f,3f);

        float randomScream = UnityEngine.Random.Range(0f, 2f);

        if (randomScream < 1f)
        {
                      
            scream1 = true;
            scream2 = false;
          
        }
        else
        {

           
            scream1 = false;
            scream2 = true;
           
        }

        if (randomFloat < 1f) {
			
			m_Anim.SetInteger ("jumpInt", 0);
			


		} else if (randomFloat >= 1f && randomFloat < 2f) {
			
			m_Anim.SetInteger ("jumpInt", 1);
			

		
		} else {
		
			m_Anim.SetInteger ("jumpInt", 2);
			

		
		}
		
		}
        private void FixedUpdate()
        {
		if (groundOnce) {
			
			StartCoroutine (waitGround ());
            trailParticle.Play();
            groundOnce = false;
		
		}

		if(gameObject.GetComponent<Rigidbody2D>().velocity.y < -1f)m_Grounded = false;
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y > 1f) m_Grounded = false;

        // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
        // This can be done using layers instead but Sample Assets will not overwrite your project settings.
        Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
            for (int i = 0; i < colliders.Length; i++)
            {
				if (colliders [i].gameObject != gameObject) {

					if (playOnce) {
						landOnce = true;
						hitSound.Play ();
					    bumpParticle.Play ();
						// iTween.PunchRotation (mainCam, new Vector3 (0, 0, 1.5f), 0.5f);
						//LeanTween.rotateZ(mainCam, 3f, 0.5f).setEase(LeanTweenType.punch);
						//LeanTween.rotateZ(mainCam, 0f, 0.5f);
						//LeanTween.scale(mainCam, Vector3.one*3f, 0.5f).setEase(LeanTweenType.punch);

					if(!isDead)skiingSound.Play ();
						
						playOnce = false;

					}

					

					m_Grounded = true;
				//rCam.zoomOut = false;
					

				}
								
				    
            }
		if (!isDead && !boostActivate && !isRocket) {
			if (m_MaxSpeed > 20f && decreaseSpeed)
				boostOrig -= acceleration * 10f *Time.deltaTime;

			if (boostOrig > 20f && decreaseSpeed)
				boostOrig -= acceleration * 10f * Time.deltaTime;

			if (m_MaxSpeed < 20f && !decreaseSpeed)
				m_MaxSpeed += acceleration * Time.deltaTime;

			if (boostOrig < 20f && !decreaseSpeed)
				boostOrig += acceleration * Time.deltaTime;

		} else if(isDead){
		
			
			fadeOutScript.isStarted = false;

			m_MaxSpeed = 0f;

			gameObject.GetComponent<TrailRenderer> ().enabled = false;
		
		}

            m_Anim.SetBool("Ground", m_Grounded);


            // Set the vertical animation
            m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);
			if (m_Grounded) {


			
				doubleJump = false;
			m_Anim.SetBool("doubleJump", false);
			shiftAnimOnce = true;
			}
        
			if(!m_Grounded){
			skiingSound.Stop ();
				trailParticle.Pause ();
				playOnce = true;
			}
		}




        public void Move(float move, bool crouch, bool jump)
        {
            // If crouching, check to see if the character can stand up
            if (!crouch && m_Anim.GetBool("Crouch"))
            {
                // If the character has a ceiling preventing them from standing up, keep them crouching
                if (Physics2D.OverlapCircle(m_CeilingCheck.position, k_CeilingRadius, m_WhatIsGround))
                {
                    crouch = true;
                }
            }

            // Set whether or not the character is crouching in the animator
            m_Anim.SetBool("Crouch", crouch);

            //only control the player if grounded or airControl is turned on
            if (m_Grounded || m_AirControl)
            {

			airActive = false;
                // Reduce the speed if crouching by the crouchSpeed multiplier
                move = (crouch ? move*m_CrouchSpeed : move);

                // The Speed animator parameter is set to the absolute value of the horizontal input.
                m_Anim.SetFloat("Speed", Mathf.Abs(move));

                // Move the character
                m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);

                // If the input is moving the player right and the player is facing left...
                if (move > 0 && !m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
                    // Otherwise if the input is moving the player left and the player is facing right...
                else if (move < 0 && m_FacingRight)
                {
                    // ... flip the player.
                    Flip();
                }
            }
        // If the player should jump...
        if (((m_Grounded || !doubleJump) && !isDead) && jump /*&& m_Anim.GetBool("Ground")*/)
        {
            // Add a vertical force to the player.


            if (jumpCount == 0f)
            {
                if (randomFloat < 1f)
                {


                    jumpSound.Play();

                }
                else if (randomFloat >= 1f && randomFloat < 2f)
                {

                    jumpSoundTwo.Play();

                }
                else
                {

                    jumpSoundThree.Play();

                }
            }
            else {

                if(randomFloat < 1f)
                {


                    doubleJumpSound.Play();

                }
                else if (randomFloat >= 1f && randomFloat < 2f)
                {

                    doubleJumpSoundTwo.Play();

                }
                else
                {

                    doubleJumpSoundThree.Play();

                }

               

            }
               // m_Grounded = false;

			skiingSound.Stop ();

			StartCoroutine (waitGround ());

				

			m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x, 0);


				
			if (jumpCount > 0f) {
				m_Rigidbody2D.AddForce (new Vector2 (0f, m_JumpForce / 1.3f), ForceMode2D.Impulse);
			} else {
				m_Rigidbody2D.AddForce (new Vector2 (0f, m_JumpForce), ForceMode2D.Impulse);
			}

			


			
				bumpParticle.Play ();

				// iTween.PunchRotation (mainCam, new Vector3 (0, 0, 1.5f), 0.5f);
				//LeanTween.rotateZ(mainCam, 3f, 0.5f).setEase(LeanTweenType.punch);
				//LeanTween.rotateZ(mainCam, 0f, 0.5f);
				//LeanTween.scale(mainCam, Vector3.one*3f, 0.5f).setEase(LeanTweenType.punch);

				//if (!m_Grounded) {
					
			if ((!m_Anim.IsInTransition (0) || !m_Anim.IsInTransition (1)||!m_Anim.IsInTransition (2)) && shiftAnimOnce) {

				//rCam.zoomOut = true;

				m_Anim.SetBool ("doubleJump", true);
				shiftAnimOnce = false;

			} else {


				//rCam.zoomOut = false;
				m_Anim.SetBool ("doubleJump", false);
				shiftAnimOnce = false;

			}



					doubleJump = true;
				

				//} else {
				
				//	doubleJump = false;

				//}

            }
        }


        private void Flip()
        {
            // Switch the way the player is labelled as facing.
            m_FacingRight = !m_FacingRight;

            // Multiply the player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }


		/*IEnumerator CamShake(float shakeAmmount){

			LeanTween.rotateZ(mainCam, shakeAmmount, 0.5f).setEase(LeanTweenType.punch);
			yield return new WaitForSeconds (0.5f);
			LeanTween.rotateZ(mainCam, 0f, 0.5f);

    	}*/



	void OnTriggerEnter2D(Collider2D other)
	{



		if (other.gameObject.tag == "SpeedBooster") {


			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();
			StartCoroutine(waitSpawnBooster());
			//  particleHit.Play();


		}

		if (other.gameObject.tag == "ObstacleAvoided") {
            

            feedbackMesh.gameObject.SetActive (true);
			if (randomFloat < 1f) {
                applauseSound.Play();

                feedbackText.text = "Great!";
				obstacleAvoidedTwo.Play();

			} else if (randomFloat >= 1f && randomFloat < 2f) {
                applauseSoundTwo.Play();
                feedbackText.text = "Awesome!";
				obstacleAvoidedThree.Play();

			} else {
                applauseSoundThree.Play();
				feedbackText.text = "Nice!";
				obstacleAvoided.Play();

			}

			//iTween.PunchScale(this.gameObject,new Vector3(0.2f,0.2f,0.2f), 1f);
			//this.gameObject.GetComponent<AudioSource>().Play();


			feedbackMesh.enabled = true;
			feedbackAnimator.SetBool ("Avoided", true);
			StartCoroutine (waitFeedback ());
			//  particleHit.Play();


		}

	}

	IEnumerator waitSpawnBooster(){
	
		//groundSpawnScript.Spawn();
		hudScriptPoints.scoreOverTimeAmmount = hudScriptPoints.scoreOverTimeAmmount * 2f;
		yield return new WaitForSeconds (2f);
		hudScriptPoints.scoreOverTimeAmmount = origAmmount;


	
	}

	IEnumerator waitFeedback(){

		//groundSpawnScript.Spawn();



		yield return new WaitForSeconds (1f);

		feedbackMesh.enabled = false;
		feedbackAnimator.SetBool ("Avoided", false);
		feedbackMesh.gameObject.SetActive (false);

		yield return new WaitForSeconds (0.2f);




	}

	IEnumerator waitFeedbackTwo(){

		yield return new WaitForSeconds (1f);

		feedbackOnce = true;

		yield return new WaitForSeconds (0.5f);

		feedbackOnceTwo = true;


	}

	IEnumerator waitGround(){

		groundOnce = false;
        m_Grounded = false;
        yield return new WaitForSeconds (0.04f);

		m_Grounded = false;
		m_Anim.SetBool("Ground", false);

		yield return new WaitForSeconds (0.1f);

		jumpCount = 0f;
		//groundOnce = false;


	}



	IEnumerator waitDeathOfSpeed(){



		yield return new WaitForSeconds (2f);

		if (gameObject.GetComponent<Rigidbody2D> ().velocity.x < 8f) {
		
			destroyerScript.dieBool = true;

		
		} else {
		
			speedDeathOnce = true;

		}



	}

	IEnumerator waitRocket(){
	
		yield return new WaitForSeconds (4f);

		rocketActivate = true;
		yield return new WaitForSeconds (8f);
		isRocket = false;
		isRocketOnce = true;
		rocketActivate = false;
	}

	}

	

//}
