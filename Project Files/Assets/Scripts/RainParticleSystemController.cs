using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainParticleSystemController : MonoBehaviour {

    public bool on;
    public ParticleSystem part;
	// Use this for initialization
	void Start () {
        on = gameObject.transform.parent.gameObject.GetComponent<RainController>().on;
        part = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        on = gameObject.transform.parent.gameObject.GetComponent<RainController>().on;
        if (on)
        {
            part.Play();
        }
        else
        {
            part.Pause();
        }
	}
}
