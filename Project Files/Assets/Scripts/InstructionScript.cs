﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene("Aqueduct", LoadSceneMode.Single);
        }
    }
}
