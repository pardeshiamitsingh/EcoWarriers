using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemTrailController : MonoBehaviour {

    public ParticleSystem part;
    public bool on = false;
    AudioSource spray;
    bool hasAudioSource = false;

    private void Start()
    {
        if(GetComponent<AudioSource>() != null)
        {
            hasAudioSource = true;
            spray = GetComponent<AudioSource>();
        }
    }

    void Update () {
        if(Input.GetButtonDown("Jump"))
        {
            on = !on;
            if(hasAudioSource && on)
            {
                spray.Play();
            }
            else if (hasAudioSource && !on)
            {
                spray.Stop();
            }
        }
        
        if(on)
        {
            part.Play();
        }
        else if(!on)
        {
            part.Pause();
        }


	}
}
