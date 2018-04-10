using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour {

    float cloudLife = 30;
    float currentCloudLife;

    public float seedTime = 10;
    public float maxSeedTime;
    public ChemTrailController chemTrailController;
    public MeshRenderer mr;
    public bool canInjurePlayer;
    public CloudsSeededCounterController cloudsSeededCounterController;
    bool seeded;

    float cloudMoveDelay = 20;
    float cloudMoveTimer = 0;
    bool getNewCloudPos;
    float speed = .25f;
    Vector3 targetPos;
    float step;

    private void Start()
    {
        chemTrailController = GameObject.FindWithTag("ChemTrailEmitter").GetComponent<ChemTrailController>();
        maxSeedTime = seedTime;
        mr = GetComponent<MeshRenderer>();
        canInjurePlayer = false;
        seeded = false;
        getNewCloudPos = false;
        cloudsSeededCounterController = GameObject.FindGameObjectWithTag("CloudSeededCounterController").GetComponent<CloudsSeededCounterController>();
        targetPos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10) );

        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().currentAmountOfClouds++;
        currentCloudLife = cloudLife + Time.time;
    }

    private void Update()
    {

        if (getNewCloudPos)
        {
            targetPos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            getNewCloudPos = false;
        }
        else if(Time.time > cloudMoveTimer)
        {
            cloudMoveTimer = Time.time + cloudMoveDelay;
            getNewCloudPos = true;
        }

        step = speed * Time.deltaTime;
        this.transform.localPosition = Vector3.MoveTowards(this.transform.localPosition, targetPos, step);

        if(Time.time > currentCloudLife && !seeded)
        {
            Destroy(this.gameObject);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().currentAmountOfClouds--;
        }

    }

    private void OnTriggerStay(Collider other)
    {    
        if(other.CompareTag("CTC") && chemTrailController.on)
        {

            seedTime -= Time.deltaTime;

            mr.material.color = Color.Lerp(Color.black, Color.white, seedTime/maxSeedTime);


            if (seedTime < 0 && !seeded )
            {
                cloudsSeededCounterController.cloudsSeeded++;
                canInjurePlayer = true;
                seeded = true;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
