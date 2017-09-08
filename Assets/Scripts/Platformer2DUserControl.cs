using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
		public ParticleSystem spamParticle;

		public LavineMove lavineScript;
		public GameObject mainCamObj;
		public AudioSource lavineSound1;
		public AudioSource lavineSound2;

		public GameObject lavineEndPos;
		public GameObject lavineEndPosOrig;
		//public bool lavineActive = true;
		public bool moveBackSpam = false;

        public DisableJumpBelow disableJumpScript;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }

		void Start(){



		}

        private void Update()
        {
			if (moveBackSpam && lavineScript.spamActive && !lavineScript.isDeadByLavine) {
				
				lavineScript.transform.position = Vector3.MoveTowards (lavineScript.transform.position, lavineEndPos.transform.position, 3f * Time.deltaTime);
			
			} else if(!moveBackSpam && lavineScript.spamActive && !lavineScript.isDeadByLavine){
				
				lavineScript.transform.position = Vector3.MoveTowards(lavineScript.transform.position, lavineEndPosOrig.transform.position, 5f * Time.deltaTime);
			
			
			}

				
			if (!m_Jump && (Input.touchCount > 0) && Input.GetTouch (0).phase == TouchPhase.Began && Time.timeScale <=1.3f) {
			


				if (!lavineScript.spamActive && !disableJumpScript.disableJump) {

                   // EZCameraShake.CameraShaker.Instance.ShakeOnce(m_Character.shakeMagnitude, m_Character.shakeRoughness, m_Character.shakeFadeIn, m_Character.shakeFadeOut);
                    StartCoroutine (waitCountOne ());
					m_Jump = true;
					m_Character.feedbackTap = false;

				} else {

					//m_Jump = true;
					/*if (lavineScript.isLavine) {
						lavineScript.transform.position -= new Vector3 (1f, 0f, 0f);
					} else {*/
					lavineEndPos.transform.position -= new Vector3 (1f, 0f, 0f);
					moveBackSpam = true;
					StartCoroutine (waitMoveBackSpam ());

					//}
					lavineScript.touchCounter += 1;
					lavineScript.tTap = 0f;
					//m_Character.feedbackTap = true;



					if (lavineScript.randomSoundFloat < 0.5f) {
						
						lavineSound1.Play ();

					} else {
						
						lavineSound2.Play ();

					}

					if (m_Character.m_MaxSpeed < 15f)
						m_Character.m_MaxSpeed += 0.1f;
					spamParticle.Play ();

				}

			} 
			if ((Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) && Time.timeScale <=1.3f) {



				if (!lavineScript.spamActive && !disableJumpScript.disableJump) {

                   // EZCameraShake.CameraShaker.Instance.ShakeOnce(m_Character.shakeMagnitude, m_Character.shakeRoughness, m_Character.shakeFadeIn, m_Character.shakeFadeOut);
                    StartCoroutine (waitCountOne ());
					m_Jump = true;
					m_Character.feedbackTap = false;

				} else {

					//m_Jump = true;
					/*if (lavineScript.isLavine) {
						lavineScript.transform.position -= new Vector3 (1f, 0f, 0f);
					} else {*/
						lavineEndPos.transform.position -= new Vector3 (1f, 0f, 0f);
						moveBackSpam = true;
						StartCoroutine (waitMoveBackSpam ());

					//}
					//if(m_Character.m_MaxSpeed < 15f)m_Character.m_MaxSpeed += 0.1f;
					lavineScript.touchCounter += 1;
					lavineScript.tTap = 0f;
					//m_Character.feedbackTap = true;

					if (lavineScript.randomSoundFloat < 0.5f) {

						lavineSound1.Play ();

					} else {

						lavineSound2.Play ();

					}

					spamParticle.Play ();
				
				}

			} 

			if (!m_Jump && !lavineScript.spamActive)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");

            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            // bool crouch = Input.GetKey(KeyCode.LeftControl);
            // float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(1, false, m_Jump);
            m_Jump = false;
        }

		IEnumerator waitCountOne(){
			yield return new WaitForSeconds (0.2f);

			m_Character.jumpCount += 1f;


		}

		IEnumerator waitMoveBackSpam(){
			yield return new WaitForSeconds (1f);
			moveBackSpam = false;


		}


    }


}
