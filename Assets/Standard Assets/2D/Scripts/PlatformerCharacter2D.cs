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

        private Transform m_GroundCheck;    // A position marking where to check if the player is grounded.
        const float k_GroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
        private bool m_Grounded;            // Whether or not the player is grounded.
        private Transform m_CeilingCheck;   // A position marking where to check for ceilings
        const float k_CeilingRadius = .01f; // Radius of the overlap circle to determine if the player can stand up
        private Animator m_Anim;            // Reference to the player's animator component.
        private Rigidbody2D m_Rigidbody2D;
        private bool m_FacingRight = true;  // For determining which way the player is currently facing.

		public ParticleSystem bumpParticle;
		private bool playOnce = true;

		public bool isDead = false;
		public AudioSource jumpSound;
		public AudioSource hitSound;

		bool doubleJump = false;

		public GameObject mainCam;

		public ParticleSystem trailParticle;
		private float randomFloat = 0f;
	public bool scream1 = true;
	public bool scream2 = true;
	public bool scream3 = true;

	private bool shiftAnimOnce = true;

        private void Awake()
        {

			//Application.targetFrameRate = 60;
            // Setting up references.
            m_GroundCheck = transform.Find("GroundCheck");
            m_CeilingCheck = transform.Find("CeilingCheck");
            m_Anim = GetComponent<Animator>();
            m_Rigidbody2D = GetComponent<Rigidbody2D>();
        }

		void Update(){
		
		randomFloat = UnityEngine.Random.Range(0f,3f);

		if (randomFloat < 1f) {
			
			m_Anim.SetInteger ("jumpInt", 0);
			scream1 = true;
			scream2 = false;
			scream3 = false;


		} else if (randomFloat >= 1f && randomFloat < 2f) {
			
			m_Anim.SetInteger ("jumpInt", 1);
			scream1 = false;
			scream2 = true;
			scream3 = false;

		
		} else {
		
			m_Anim.SetInteger ("jumpInt", 2);
			scream1 = false;
			scream2 = false;
			scream3 = true;

		
		}
		
		}
        private void FixedUpdate()
        {
            m_Grounded = false;

            // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
            // This can be done using layers instead but Sample Assets will not overwrite your project settings.
            Collider2D[] colliders = Physics2D.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround);
            for (int i = 0; i < colliders.Length; i++)
            {
				if (colliders [i].gameObject != gameObject) {

					if (playOnce) {
						hitSound.Play ();
					    bumpParticle.Play ();
						// iTween.PunchRotation (mainCam, new Vector3 (0, 0, 1.5f), 0.5f);
						//LeanTween.rotateZ(mainCam, 3f, 0.5f).setEase(LeanTweenType.punch);
						//LeanTween.rotateZ(mainCam, 0f, 0.5f);
						//LeanTween.scale(mainCam, Vector3.one*3f, 0.5f).setEase(LeanTweenType.punch);



						playOnce = false;

					}


					m_Grounded = true;
					trailParticle.Play ();

				}
								
				    
            }

			m_MaxSpeed += 0.005f * Time.deltaTime;

            m_Anim.SetBool("Ground", m_Grounded);


            // Set the vertical animation
            m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);
			if (m_Grounded) {
			
				doubleJump = false;
			m_Anim.SetBool("doubleJump", false);
			shiftAnimOnce = true;
			}
        
			if(!m_Grounded){
				trailParticle.Stop ();
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

				jumpSound.Play ();
                m_Grounded = false;
                m_Anim.SetBool("Ground", false);
				

				m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x, 0);

                m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));


			
				bumpParticle.Play ();

				// iTween.PunchRotation (mainCam, new Vector3 (0, 0, 1.5f), 0.5f);
				//LeanTween.rotateZ(mainCam, 3f, 0.5f).setEase(LeanTweenType.punch);
				//LeanTween.rotateZ(mainCam, 0f, 0.5f);
				//LeanTween.scale(mainCam, Vector3.one*3f, 0.5f).setEase(LeanTweenType.punch);

				//if (!m_Grounded) {
					
			if ((!m_Anim.IsInTransition (0) || !m_Anim.IsInTransition (1)||!m_Anim.IsInTransition (2)) && shiftAnimOnce) {
				
				m_Anim.SetBool ("doubleJump", true);
				shiftAnimOnce = false;

			} else {
				
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


	}

	

//}
