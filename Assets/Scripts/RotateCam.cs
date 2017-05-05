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

	// Use this for initialization
	void Start () {

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
			
			transform.position = Vector3.MoveTowards (transform.position, normPos.position, 7f * Time.deltaTime);


		} else if(!lavineScript.spamActive){
		
			if (zoomOut && !lavineScript.spamActive) {

				//	normPos = zoomOutPos;

				transform.position = Vector3.MoveTowards (transform.position, zoomOutPos.position, 7f * Time.deltaTime);

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
				transform.position = Vector3.MoveTowards (transform.position, normPos.position, 7f * Time.deltaTime);
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


		if (lavineScript.spamActive && transform.position.x > backpos.position.x) {
		
			transform.position -= new Vector3 (4f,0f,0f) * Time.deltaTime;
		
		}else if(!lavineScript.spamActive && transform.position.x < normPos.position.x){

			transform.position += new Vector3 (4f,0f,0f) * Time.deltaTime;


		}


			if (lavineScript.spamActive && transform.position.z < backpos.position.z) {

				transform.position += new Vector3 (0f, 0f, 4f) * Time.deltaTime;

			} /*else if (!lavineScript.spamActive && transform.position.z > normPos.position.z) {

				transform.position -= new Vector3 (0f, 0f, 4f) * Time.deltaTime;


			}*/
		

		if (lavineScript.spamActive && transform.position.y > backpos.position.y) {

			transform.position -= new Vector3 (0f,4f,0f) * Time.deltaTime;

		}

		angle = gameObject.transform.rotation.eulerAngles.z;

		if (gameObject.transform.rotation.eulerAngles.z < 40f) {
			

			pc2D.decreaseSpeed = true;

		} else {

			pc2D.decreaseSpeed = false;
		
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
			
				angleMultiplier -= 0.5f * Time.deltaTime;
			
			} else {
			
				changeSmooth = false;
			
			}
		
		}

		if(t < 1f)t += 0.5f * Time.deltaTime;

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
}
