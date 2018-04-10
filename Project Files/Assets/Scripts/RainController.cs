using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour {

    GameObject cloud;
    public bool on;
    float seedTime;

	// Use this for initialization
	void Start () {
        on = false;
        seedTime = gameObject.transform.parent.gameObject.GetComponent<CloudScript>().seedTime;
    }

    // Update is called once per frame
    void Update () {
        seedTime = gameObject.transform.parent.gameObject.GetComponent<CloudScript>().seedTime;
        if (seedTime <= 0)
        {
            on = true;
        }
	}
}
