using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    float warningMessageTimer;
    int warningMessageTimerForFlashing;
    public float warningMessageDisplayLength;

    public float playerHealth;
    bool hasBeenDamagedOnThisPass;
    public bool warning;
    
	// Use this for initialization
	void Start () {
        hasBeenDamagedOnThisPass = false;
        warning = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(warning && Time.time > warningMessageTimer)
        {
            warning = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cloud") && other.gameObject.GetComponent<CloudScript>().canInjurePlayer && !hasBeenDamagedOnThisPass )
        {
            playerHealth -= 1;
            hasBeenDamagedOnThisPass = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Cloud") && hasBeenDamagedOnThisPass)
        {
                warning = true;
                warningMessageTimer = Time.time + warningMessageDisplayLength;
                hasBeenDamagedOnThisPass = false;
        }
    }
}
