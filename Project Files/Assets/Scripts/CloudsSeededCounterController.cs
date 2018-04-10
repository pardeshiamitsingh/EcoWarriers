using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudsSeededCounterController : MonoBehaviour {

    public Text counter;
    public int cloudsSeeded;
    
    void Start () {
        counter = GetComponent<Text>();
        cloudsSeeded = 0;
	}
	
	void Update () {
        counter.text = "Clouds Seeded: " + cloudsSeeded.ToString() + "/" + GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().winCondition;
	}
}
