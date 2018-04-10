using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointCollision : MonoBehaviour {

	public GameObject water1,water2;
	public float chkDistance;
	GameObject player;
	public Text items;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	void Update()
	{
		
		float dist = Vector3.Distance(player.transform.position, transform.position);
		if (dist < chkDistance)
		{
			CountDownTimer.count--;
			CountUpdate ();
			this.gameObject.SetActive (false);

			water1.SetActive (true);

			if (water2 != null)
				water2.SetActive (true);
        
            GameObject.FindGameObjectWithTag("DesertCheckpointSound").GetComponent<AudioSource>().Play();
		}
	}

	void CountUpdate()
	{
		//Debug.Log ("Reached Count too");
		items.text = "Items Remaining: " + CountDownTimer.count.ToString ();
	}


}
