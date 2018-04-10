using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ItemsCollect : MonoBehaviour {
    public static int NumBottlesRemaining = 0;
    public static int NumBagsRemaining = 0;
	public static int NumBeerRemaining = 0;
	public static int NumPartHornRemaining = 0;
	public static int NumChampagneRemaining = 0;
	public static int NumOilCansRemaining = 0;

	// Use this for initialization
	GameObject[] bottle;
	GameObject[] bag;
	GameObject[] beer;
	GameObject[] partyhorn;
	GameObject[] champagne;
	GameObject[] oilcan;

	public static Text countText;
    public Text winText;
	public Text timerText;
	public Text outputText;

    public float timeRemaining = 120f;
	public  int count;
    private bool isGameStarted = false;
    private bool gameEnded = false;
    // Time in seconds to delay before next scene appears
    public float delayTime = 2f;
	public int totalPoints = 100;


    void Start()
    {
        NumBottlesRemaining += 1;
        NumBagsRemaining += 1;
		NumBeerRemaining += 1;
		NumPartHornRemaining += 1;
		NumChampagneRemaining += 1;
		NumOilCansRemaining += 1;
        count = 0;
        countText.text = "";
        setCountText();
        winText.text = "";
		outputText.text = "";

        isGameStarted = true;

		bottle = GameObject.FindGameObjectsWithTag("bottle");
		bag = GameObject.FindGameObjectsWithTag("bag");
		beer = GameObject.FindGameObjectsWithTag("beer");
		partyhorn = GameObject.FindGameObjectsWithTag("partyhorn");
		champagne = GameObject.FindGameObjectsWithTag("champagne");
		oilcan = GameObject.FindGameObjectsWithTag("oilcan");
    }

    private void Update()
    {   
		string returnText;
		if (Input.GetMouseButtonDown (0)) {

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				Debug.Log (hit.collider.tag);

				string hitTag = hit.collider.tag;
				cleanLake (hitTag);
				outputText.text = "";
			}
		}

        if (timeRemaining > 0.0 && !gameEnded)
        {
            timeRemaining -= Time.deltaTime;
            if(timeRemaining > -0.0) {
                UpdateLevelTimer(timeRemaining);
            }
            
        }
        if (timeRemaining < 0)
        {
            isGameStarted = false;
            gameEnded = true;
        }
        if (timeRemaining < 0 && gameEnded == true)
        {
            winText.text = "You Lose !";
			GrandGameController.aqueductCompleted = false;
			//To freeze the screen player times out
            // Time.timeScale = 0;
			Invoke("DelayedAction", delayTime);
        }

        if (Input.GetKey("escape"))
            Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bottle"))
        {
            NumBottlesRemaining -= 1;
            other.gameObject.SetActive(false);
            count = count + 50;
            setCountText();
        } else if (other.gameObject.CompareTag("bag"))
        {
            NumBagsRemaining -= 1;
            other.gameObject.SetActive(false);
            count = count + 80;
            setCountText();
		} else if (other.gameObject.CompareTag("beer"))
		{
			NumBeerRemaining -= 1;
			other.gameObject.SetActive(false);
			count = count + 70;
			setCountText();
		} else if (other.gameObject.CompareTag("partyhorn"))
		{
			NumPartHornRemaining -= 1;
			other.gameObject.SetActive(false);
			count = count + 30;
			setCountText();
		} else if (other.gameObject.CompareTag("champagne"))
		{
			NumChampagneRemaining -= 1;
			other.gameObject.SetActive(false);
			count = count + 20;
			setCountText();
		} else if (other.gameObject.CompareTag("oilcan"))
		{
			NumOilCansRemaining -= 1;
			other.gameObject.SetActive(false);
			count = count + 50;
			setCountText();
		}


        if (count >= totalPoints && timeRemaining >= 0)
        {
            gameEnded = true;
            GrandGameController.aqueductCompleted = true;
            //	Time.timeScale = 0;
            winText.text = "You Win !";
            Invoke("DelayedAction", delayTime);
           // return true;
        }
        /*if (NumBottlesRemaining <= 0 && NumBagsRemaining <= 0 
			&& NumBeerRemaining <= 0 && NumPartHornRemaining <= 0
			&& NumChampagneRemaining <= 0 && NumOilCansRemaining <= 0 
			&& timeRemaining >= 0)
        {
            gameEnded = true;
			GrandGameController.aqueductCompleted = true;
          //  Time.timeScale = 0;
            winText.text = "You Win !";
            Invoke("DelayedAction", delayTime);
        }*/
    }

	private bool cleanLake(string objSelected)
	{
		if ("bottle".CompareTo(objSelected) == 0)
		{
			NumBottlesRemaining -= 1;
			bottle[0].gameObject.SetActive(false);
			count = count + 50;
			setCountText();
		} else if ("bag".CompareTo(objSelected) == 0)
		{
			NumBagsRemaining -= 1;
			bag[0].gameObject.SetActive(false);
			count = count + 80;
			setCountText();
		} else if ("beer".CompareTo(objSelected) == 0)
		{
			NumBeerRemaining -= 1;
			beer[0].gameObject.SetActive(false);
			count = count + 70;
			setCountText();
		} else if ("partyhorn".CompareTo(objSelected) == 0)
		{
			NumPartHornRemaining -= 1;
			partyhorn[0].gameObject.SetActive(false);
			count = count + 30;
			setCountText();
		} else if ("champagne".CompareTo(objSelected) == 0)
		{
			NumChampagneRemaining -= 1;
			champagne[0].gameObject.SetActive(false);
			count = count + 20;
			setCountText();
		} else if ("oilcan".CompareTo(objSelected) == 0)
		{
			NumOilCansRemaining -= 1;
			oilcan[0].gameObject.SetActive(false);
			count = count + 50;
			setCountText();
		}

		if (count >= totalPoints && timeRemaining >= 0)
		{
			gameEnded = true;
			GrandGameController.aqueductCompleted = true;
		//	Time.timeScale = 0;
			winText.text = "You Win !";
			Invoke("DelayedAction", delayTime);
			return true;
		}
		return false;
	}

	//setting the count text for display
    public  void setCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

	//set the format of timer for display
    void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    void DelayedAction()
    {
        SceneManager.LoadScene("Village", LoadSceneMode.Single);
    }

}
