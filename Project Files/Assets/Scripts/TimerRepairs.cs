using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerRepairs : MonoBehaviour {
    
    Text text;

    float timer;
    public float playTime;
    public float timeRemaining;

    int minutes;
    int seconds;


    void Start () {
        text = GetComponent<Text>();
        timer = Time.time + playTime;
        timeRemaining = timer;
    }
	
    
	// Update is called once per frame
	void Update () {

        timeRemaining = timer - Time.time;

        minutes = (int) timeRemaining / 60;
        seconds = (int) timeRemaining % 60;

        text.text = "Time Remaining: " + minutes + ":" + seconds;
	}
}
