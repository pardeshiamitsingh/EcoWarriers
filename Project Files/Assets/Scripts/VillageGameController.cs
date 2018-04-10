using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageGameController : MonoBehaviour {

    bool cloudOn;
    bool villageOn;
    bool lakeOn;

    public GameObject cloud;
    public GameObject houses;
    public GameObject lake;

	// Use this for initialization
	void Start () {
        cloudOn = GrandGameController.cloudCompleted;
        villageOn = GrandGameController.desertCompleted;
        lakeOn = GrandGameController.aqueductCompleted;
    }
	
	// Update is called once per frame
	void Update () {
		if(cloudOn)
        {
            cloud.SetActive(true);
            
        }

        if(villageOn)
        {
            houses.SetActive(true);
        }

        if(lakeOn)
        {
            lake.SetActive(true);
        }
	}
}
