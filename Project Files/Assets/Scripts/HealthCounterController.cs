using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounterController : MonoBehaviour {
    public Text health;
    public Text warningMessage;
    public float playerHealth;
    bool warning;

	// Use this for initialization
	void Start () {
        health = GetComponent<Text>();
        warningMessage = GameObject.FindGameObjectWithTag("HudWarning").GetComponent<Text>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().playerHealth;
        warning = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().warning;
    }
	
	// Update is called once per frame
	void Update () {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().playerHealth;
        warning = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().warning;

        health.text = "Player Health: " + playerHealth.ToString();

        if(warning)
        {
            warningMessage.text = "Ouch! Don't fly through storm clouds! You'll damage the plane!";
        }
        else
        {
            warningMessage.text = "";
        }
    }
}
