using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpeed : MonoBehaviour {

    // public ParticleSystem ParticleSystem;

    public ParticleSystem particleSystem;

    public PlatformerCharacter2D pc2D;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   void LateUpdate()
    {

        ParticleSystem.Particle[] p = new ParticleSystem.Particle[particleSystem.particleCount + 1];
        int l = particleSystem.GetParticles(p);

        int i = 0;
        while (i < l)
        {
            p[i].velocity = new Vector3(-pc2D.m_MaxSpeed / 2f, 0f, 0f);
            i++;
        }

        particleSystem.SetParticles(p, l);

    }
}
