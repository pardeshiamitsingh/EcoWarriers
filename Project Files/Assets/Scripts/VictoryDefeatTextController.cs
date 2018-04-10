using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryDefeatTextController : MonoBehaviour {
    bool victory;
    bool defeat;

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        victory = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().win;
        defeat = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().lose;
    }
	
	// Update is called once per frame
	void Update () {
        victory = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().win;
        defeat = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().lose;

        if (victory)
        {
            text.text = "You Win!";
            text.color = Color.green;
        }  
        else if(defeat)
        {
            text.text = "You Lose!";
            text.color = Color.red;
        }
    }
}
