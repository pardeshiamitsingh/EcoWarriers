using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("ToCloud") && !GrandGameController.cloudCompleted)
        {
			SceneManager.LoadScene("CloudInstructions", LoadSceneMode.Single);
           // SceneManager.LoadScene("Clouds", LoadSceneMode.Single);
        }

        else if (other.CompareTag("ToAqueduct") && !GrandGameController.aqueductCompleted)
        {
            SceneManager.LoadScene("AquaInstructions", LoadSceneMode.Single);
            // SceneManager.LoadScene("Aqueduct", LoadSceneMode.Single);
        }

        else if (other.CompareTag("ToDesert") && !GrandGameController.desertCompleted)
        {
            //SceneManager.LoadScene("Desert", LoadSceneMode.Single);
			SceneManager.LoadScene("DesertInstructions", LoadSceneMode.Single);
        }


    }
}
