using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningParticleSystemController : MonoBehaviour {

    bool on;
    public ParticleSystem part;
    // Use this for initialization
    void Start()
    {
        on = gameObject.transform.parent.gameObject.GetComponent<LightningController>().on;
        part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        on = gameObject.transform.parent.gameObject.GetComponent<LightningController>().on;
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
