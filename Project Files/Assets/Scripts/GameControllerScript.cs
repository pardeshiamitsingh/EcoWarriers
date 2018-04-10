using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {

    public GameObject explosion;
    public float playerHealth;
    public int cloudsSeeded;
    public float chemicalTankAmount;

    public GameObject cloud;
    public int maxAmountOfClouds;
    public int currentAmountOfClouds;
    public Vector3 spawnAreaSize;
    //Cloud Time Variables
    public float cloudSpawnTime;
    float currentCloudSpawnTimer;


    bool reset = false;

    public int winCondition;

    public bool running;
    public bool win;
    public bool lose;
    float timeRemaining;

    public GameObject timer;
    public float sceneTransitionTimer;


    void Start () {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().playerHealth;
        cloudsSeeded = GameObject.FindGameObjectWithTag("CloudSeededCounterController").GetComponent<CloudsSeededCounterController>().cloudsSeeded;
        chemicalTankAmount = GameObject.FindGameObjectWithTag("ChemicalTankCounterController").GetComponent<ChemicalTankCounterController>().chemicalTank;
        timeRemaining = timer.GetComponent<TimerRepairs>().timeRemaining;
        sceneTransitionTimer = 5;
        currentAmountOfClouds = 0;

        currentCloudSpawnTimer = Time.time + cloudSpawnTime;

        running = true;
        win = false;
        lose = false;
    }
	
	void Update () {

        if(running)
        {
            reset = false;
        }

        if (!running)
        {
            if(GameObject.FindGameObjectWithTag("Player") != null)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<AeroplaneController>().Immobilize();
            }
        }

        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().playerHealth;
        cloudsSeeded = GameObject.FindGameObjectWithTag("CloudSeededCounterController").GetComponent<CloudsSeededCounterController>().cloudsSeeded;
        chemicalTankAmount = GameObject.FindGameObjectWithTag("ChemicalTankCounterController").GetComponent<ChemicalTankCounterController>().chemicalTank;
        timeRemaining = timer.GetComponent<TimerRepairs>().timeRemaining;

        if (playerHealth <= 0 && running || timeRemaining <= 0)
        {
            running = false;
            GrandGameController.cloudCompleted = false;
            lose = true;

            GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            mainCamera.transform.parent = null;
            GameObject marker = GameObject.FindGameObjectWithTag("Marker");
            marker.transform.parent = null;

            Destroy(GameObject.FindGameObjectWithTag("Player").gameObject);
            mainCamera.transform.LookAt(marker.transform);
            Object.Instantiate(explosion,marker.transform);
        }

        if (chemicalTankAmount <= 0 && running)
        {
            running = false;
            lose = true;
            GrandGameController.cloudCompleted = false;
        }

        if ((cloudsSeeded >= winCondition) && running)
        {
            running = false;
            win = true;
            GrandGameController.cloudCompleted = true;
        }

        if(currentAmountOfClouds<maxAmountOfClouds && Time.time > currentCloudSpawnTimer)
        {
            spawnCloud(RandomPointInBox(this.transform.position, spawnAreaSize));
            currentCloudSpawnTimer = Time.time + cloudSpawnTime;
        }

        if (!running && Time.time > sceneTransitionTimer)
        {
            SceneManager.LoadScene("Village", LoadSceneMode.Single);
        }

    }

    private void spawnCloud(Vector3 spawnPoint)
    {
        Object.Instantiate(cloud, spawnPoint, Quaternion.identity);
    }

    private Vector3 RandomPointInBox(Vector3 center, Vector3 size)
    {
        return center + new Vector3(
           (Random.value - 0.5f) * size.x,
           (Random.value - 0.5f) * size.y,
           (Random.value - 0.5f) * size.z
        );
    }


}
