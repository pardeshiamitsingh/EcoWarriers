using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

	public float timeRemaining;
	private bool gameEnded = false;
	private bool isGameStarted = false; 
	public Text winText;
    public Text timerText; 
	public Text items;
	public static int count;
	private float delayTime;
   // public AudioSource itemSound;


	void Start()
	{
		count = 3;
		delayTime = 5.0f;
		winText.text = "";
		timerText.text = "";
		isGameStarted = true;
		CountUpdate ();

	}

	 void Update()
	{   
		if (timeRemaining > 0.0 && !gameEnded)
		{
			//Debug.Log ("Reached here");
			timeRemaining -= Time.deltaTime;
			if(timeRemaining > -0.0) {
				UpdateLevelTimer(timeRemaining);
			}

			if (count == 0) 
			{
				winText.text = "You Win !";
				gameEnded = true;
                GrandGameController.desertCompleted = true;
				Invoke("WaitForSceneLoad",delayTime);
			}

		}
		if (timeRemaining < 0)
		{
			isGameStarted = false;
			gameEnded = true;
		}

		if (timeRemaining < 0 && gameEnded == true){
			winText.text = "You Lose !";
            GrandGameController.desertCompleted = false;
            Invoke ("WaitForSceneLoad", delayTime);
		} 
			

	}

	void UpdateLevelTimer(float totalSeconds)
	{
		//Debug.Log ("Reached Here too");
		int minutes = Mathf.FloorToInt(totalSeconds / 60f);
		int seconds = Mathf.RoundToInt(totalSeconds % 60f);


		if (seconds == 60)
		{
			seconds = 0;
			minutes += 1;
		}
	
		timerText.text =   minutes.ToString("00") + ":" + seconds.ToString("00");
	}

	void CountUpdate()
	{
		//Debug.Log ("Reached Count too");
		items.text = "Items Remaining: " + count.ToString ();
	}

	void WaitForSceneLoad() 
	{ 
			SceneManager.LoadScene("Village");
	}

}
