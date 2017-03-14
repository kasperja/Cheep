using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


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


		//public bool lavineActive = true;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {


				
			if (!m_Jump && (Input.touchCount > 0) && Input.GetTouch(0).phase == TouchPhase.Began) {
			
				if (!lavineScript.spamActive) {
					
					m_Jump = true;

				}else {

					//m_Jump = true;
					lavineScript.transform.position -= new Vector3(0.5f,0f,0f);
					lavineScript.touchCounter += 1;

					if (lavineScript.randomSoundFloat < 0.5f) {
						
						lavineSound1.Play ();

					}else{
						
					lavineSound2.Play ();

					}

					if(m_Character.m_MaxSpeed < 15f)m_Character.m_MaxSpeed += 0.1f;
					spamParticle.Play ();

				}

			}
			if (Input.GetKeyDown (KeyCode.Space)) {
			
				if (!lavineScript.spamActive) {
					
					m_Jump = true;

				} else {

					//m_Jump = true;
					lavineScript.transform.position -= new Vector3(0.5f,0f,0f);
					if(m_Character.m_MaxSpeed < 15f)m_Character.m_MaxSpeed += 0.1f;
					lavineScript.touchCounter += 1;
					if (lavineScript.randomSoundFloat < 0.5f) {

						lavineSound1.Play ();

					}else{

						lavineSound2.Play ();

					}
					spamParticle.Play ();
				
				}

			}

			if (!m_Jump)
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
    }
}
