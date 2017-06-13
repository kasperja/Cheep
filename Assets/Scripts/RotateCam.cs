using UnityEngine;
using System.Collections;

public class RotateCam : MonoBehaviour {

	private float angleMultiplier = 3f;
	public PlatformerCharacter2D pc2D;

	public float angle;

	private float maxAngle = 100f;
	private float minAngle = 5f;
	private float origMaxAngle = 100f;
	private float origMinAngle = 5f;
	private float t = 0f;

	private bool changeDirection = true;
	private bool down = true;
	public LavineMove lavineScript;
	public Transform backpos;
	public Transform normPos;
	public Transform zoomOutPos;

	public Material curvedMat;
	public Material curvedTrailMat;
	public Material curvedTrailMatLizard;
	public Material curvedTrailMatAlien;
	public Material curvedTrailMatCat;
	public Material curvedTrailMatHippo;
	private float curvature;
	private bool now = false;
	private bool nowOnce = true;

	private bool curveEnabled = true;

	private bool changeSmooth = false;

	public bool zoomOut = false;
	private Transform normOrig;
	private float zoomSpeed = 0f;
	public Camera2DFollow c2D;
	private float origDamp;

	public CameraBoxFollow cbf;

	public bool isSteep = false;

	public bool shiftMusicTo1 = true;
	public bool shiftMusicTo2 = true;
	public bool shiftMusicTo3 = true;

	public bool musicShiftReady = true;

	// Use this for initialization
	void Start () {
		origDamp = c2D.damping;


		maxAngle = Random.Range (50f, 30f);
		minAngle = Random.Range (-5f, 5f);
		origMaxAngle = maxAngle;
		origMinAngle = minAngle;
		normOrig = normPos;
		transform.position = normPos.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (pc2D.isDead) {

			c2D.damping = 0.5f;
			c2D.target = zoomOutPos;
			//transform.position = Vector3.MoveTowards (transform.position, normPos.position, 3f * Time.deltaTime);


		} else if(!lavineScript.spamActive){

			//if(cbf.horizontalOffset < 2f)cbf.horizontalOffset += 1f * Time.deltaTime;
		
			if(!pc2D.isDead)c2D.damping = origDamp;

			if (zoomOut && !lavineScript.spamActive) {

				c2D.target = zoomOutPos;
				//	normPos = zoomOutPos;

				if(zoomSpeed < 1f)zoomSpeed += 60f * Time.deltaTime;

				//transform.position = Vector3.MoveTowards (transform.position, zoomOutPos.position, zoomSpeed * Time.deltaTime);

				/*if(!lavineScript.spamActive && transform.position.z > zoomOutPos.position.z){

				//transform.position -= new Vector3 (0f,0f,6f) * Time.deltaTime;



			}*/

				/*
			if(!lavineScript.spamActive && transform.position.y < zoomOutPos.position.y){

				transform.position += new Vector3 (0f,6f,0f) * Time.deltaTime;
				//transform.position = Vector3.MoveTowards(transform.position, zoomOutPos, 4f*Time.deltaTime);

			}*/

			} else {
		
				//	normPos = normOrig;
				c2D.target = normPos;
				if(zoomSpeed > 1f)zoomSpeed -= 10f * Time.deltaTime;


				//transform.position = Vector3.MoveTowards (transform.position, normPos.position, zoomSpeed * Time.deltaTime);
				/*if(!lavineScript.spamActive && transform.position.z < normPos.position.z){

				transform.position += new Vector3 (0f,0f,6f) * Time.deltaTime;


			}
			if(!lavineScript.spamActive && transform.position.y > normPos.position.y){

				transform.position -= new Vector3 (0f,6f,0f) * Time.deltaTime;


			}*/


			}
		}


		if (changeDirection) {
		
			now = true;
		
		}
		if (now && nowOnce) {
		
		
			StartCoroutine (changeCurvature ());
			nowOnce = false;
		}


		if (curveEnabled && !down && curvature > -0.002f) {
		
			curvature -= 0.008f * Time.deltaTime;
		
		} else if (curveEnabled && down && curvature < 0.002f) {
		
			curvature += 0.008f * Time.deltaTime;
		
		} else if(!curveEnabled){
		
			curvature = 0f;
		
		}

		curvedMat.SetFloat("_Curvature", curvature);
		curvedTrailMat.SetFloat("_Curvature", curvature);
		curvedTrailMatLizard.SetFloat("_Curvature", curvature);
		curvedTrailMatAlien.SetFloat("_Curvature", curvature);
		curvedTrailMatCat.SetFloat("_Curvature", curvature);
		curvedTrailMatHippo.SetFloat("_Curvature", curvature);


		if (lavineScript.spamActive) {

			if(cbf.horizontalOffset > -2f)cbf.horizontalOffset -= 1f * Time.deltaTime;

			if(!pc2D.isDead)c2D.damping = 0.9f;
			
			c2D.target = backpos;

		} 

		angle = gameObject.transform.rotation.eulerAngles.z;

		if (gameObject.transform.rotation.eulerAngles.z < 40f) {
			

			pc2D.decreaseSpeed = true;

		} else {

			pc2D.decreaseSpeed = false;
		
		}
		if (musicShiftReady) {
			if (gameObject.transform.rotation.eulerAngles.z <= 40f && gameObject.transform.rotation.eulerAngles.z >= 20f) {

				shiftMusicTo1 = false;
				shiftMusicTo2 = true;
				shiftMusicTo3 = false;

			} else if (gameObject.transform.rotation.eulerAngles.z < 20f) {

				shiftMusicTo1 = true;
				shiftMusicTo2 = false;
				shiftMusicTo3 = false;

			} else if (gameObject.transform.rotation.eulerAngles.z > 40f) {

				shiftMusicTo1 = false;
				shiftMusicTo2 = false;
				shiftMusicTo3 = true;

			}

			StartCoroutine (musicShiftSetReady ());
			musicShiftReady = false;

		}
		angleMultiplier += 0.0f * Time.deltaTime;

		if (angleMultiplier < 0f && changeDirection) {
		
			down = true;

		} else if(changeDirection){

			down = false;
		}

		if (changeSmooth) {
		
			float angleOrig = angleMultiplier;
			if (angleMultiplier > -angleOrig) {
			
				angleMultiplier -= 0.1f * Time.deltaTime;
			
			} else {
			
				changeSmooth = false;
			
			}
		
		}

		if(t < 0.2f)t += 0.1f * Time.deltaTime;

		if (!lavineScript.spamActive) {
		
			if (gameObject.transform.rotation.eulerAngles.z > 20f) {
		

				cbf.isSteep = true;

					
				cbf.verticalOffset = Mathf.MoveTowards (cbf.verticalOffset, 1f, 1.5f * Time.deltaTime);


				cbf.horizontalOffset = Mathf.MoveTowards (cbf.horizontalOffset, 1f, 1.5f * Time.deltaTime );

				/*

				if (cbf.verticalOffset < 1f) {
					cbf.verticalOffset += 5f * Time.deltaTime; 

				} else {
				
					cbf.verticalOffset -= 5f * Time.deltaTime; 
				
				}
				if (cbf.horizontalOffset > 1f) {
					cbf.horizontalOffset -= 5f * Time.deltaTime; 

				} else {
					
					cbf.horizontalOffset += 5f * Time.deltaTime; 
				
				}

				*/
		
			} else {


				cbf.isSteep = true;

				cbf.verticalOffset = Mathf.MoveTowards (cbf.verticalOffset, 0.7f, 1.5f * Time.deltaTime);


				cbf.horizontalOffset = Mathf.MoveTowards (cbf.horizontalOffset, 2f, 1.5f * Time.deltaTime );



				/*cbf.isSteep = false;

				if (cbf.verticalOffset > 0f) {
					cbf.verticalOffset -= 5f * Time.deltaTime; 
				} 

				if (cbf.horizontalOffset < 2f) {
					cbf.horizontalOffset += 5f * Time.deltaTime; 
				} */
		
			}
		} else {
		
			cbf.verticalOffset = Mathf.MoveTowards (cbf.verticalOffset, 0f, 5f * Time.deltaTime);


			cbf.horizontalOffset = Mathf.MoveTowards (cbf.horizontalOffset, -4f, 5f * Time.deltaTime );




		
		}


		if (((gameObject.transform.rotation.eulerAngles.z >= maxAngle || gameObject.transform.rotation.eulerAngles.z <= minAngle)) && changeDirection) {

			changeSmooth = true;
			angleMultiplier = -angleMultiplier;

				
				StartCoroutine (angleOfHill ());

				changeDirection = false;
			


		} 

		if(!pc2D.isDead) gameObject.transform.Rotate (Vector3.forward * Time.deltaTime * angleMultiplier);

		//if(!pc2D.isDead) gameObject.transform.Rotate (Vector3.forward * Time.deltaTime * angleMultiplier);

		if (transform.rotation.eulerAngles.z < 90f) {
			
		} else {
			//angleMultiplier = 0f;
			//gameObject.transform.Rotate (Vector3.forward * 0f);
		}
	
	}

	IEnumerator angleOfHill(){
		
		origMaxAngle = maxAngle;
		origMinAngle = minAngle;
		maxAngle = Random.Range (80f, 50f);
		minAngle = Random.Range (-5f, 5f);
		yield return new WaitForSeconds (2f);
		changeDirection = true;

	
	}

	IEnumerator changeCurvature(){
	
		yield return new WaitForSeconds (5f);
		now = false;
		nowOnce = true;
				
	}

	IEnumerator musicShiftSetReady(){
	
		yield return new WaitForSeconds (8f);
	
		musicShiftReady = true;

	}
}
