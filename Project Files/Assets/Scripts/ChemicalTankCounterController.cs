using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChemicalTankCounterController : MonoBehaviour {

    public float chemicalTank;
    bool tanksOn;
    public Text text;

    void Start () {
        tanksOn = GameObject.FindGameObjectWithTag("ChemTrailEmitter").GetComponent<ChemTrailController>().on;
        text = GetComponent<Text>();
	}
	
	void Update () {
        tanksOn = GameObject.FindGameObjectWithTag("ChemTrailEmitter").GetComponent<ChemTrailController>().on;
        
        if(tanksOn)
        {
            chemicalTank--;
        }

        text.text = "Chemical Tank:" + chemicalTank.ToString();
    }
}
