using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRotate : MonoBehaviour {

	public ParticleSystem m_System;
	public GameObject cam;
	ParticleSystem.Particle[] m_Particles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

		InitializeIfNeeded();

		int numParticlesAlive = m_System.GetParticles (m_Particles);

		for (int i = 0; i < numParticlesAlive; i++) {

		//	Vector3 rotation = new Vector3 (0, 0, 0);
		
			m_Particles [i].rotation = -cam.transform.localRotation.z;

		}

		m_System.SetParticles (m_Particles, numParticlesAlive);


	}

	void InitializeIfNeeded()
	{
		if (m_System == null)
			m_System = GetComponent<ParticleSystem>();

		if (m_Particles == null || m_Particles.Length < m_System.maxParticles)
			m_Particles = new ParticleSystem.Particle[m_System.maxParticles]; 
	}
}
