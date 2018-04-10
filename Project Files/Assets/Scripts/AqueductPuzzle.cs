using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AqueductPuzzle : MonoBehaviour {

	// Use this for initialization
	GameObject[] s1;
	GameObject[] s2;
	GameObject[] s3;
	GameObject[] s4;

	GameObject[] p1;
	GameObject[] p2;
	GameObject[] p3;
	GameObject[] p4;

	public Text outputText;

	void Start () {
		s1 = GameObject.FindGameObjectsWithTag("s1");
		s2 = GameObject.FindGameObjectsWithTag("s2");	
		s3 = GameObject.FindGameObjectsWithTag("s3");
		s4 = GameObject.FindGameObjectsWithTag("s4");
		s1[0].gameObject.SetActive(false);
		s2[0].gameObject.SetActive(false);
		s3[0].gameObject.SetActive(false);
		s4[0].gameObject.SetActive(false);

		p1 = GameObject.FindGameObjectsWithTag("p1");
		p2 = GameObject.FindGameObjectsWithTag("p2");	
		p3 = GameObject.FindGameObjectsWithTag("p3");
		p4 = GameObject.FindGameObjectsWithTag("p4");
		outputText.text = "";



	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("IsClikeed" + OVRInput.Get(OVRInput.Button.One));

		outputText.text = "";
		string returnText;
		Debug.Log (s1[0]);
		if (Input.GetMouseButtonDown (0) || OVRInput.GetDown(OVRInput.Button.One) ) {

            GameObject[] list;

            list = GameObject.FindGameObjectsWithTag("MainCamera");

            //list[0].GetComponent < Camera >()

            RaycastHit hit;
			//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            Ray ray = list[0].GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast (ray, out hit)) {
				Debug.Log (hit.collider.tag);

				if (checkUserSelection (hit.collider.tag)) {
					outputText.text = "";
				} else {
					if (hit.collider.tag != "") {
						outputText.text = "Wrong selection";
						Debug.Log ("Wrong selection");
					}

				}

			}
		}

	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On trigger called");
        if (checkUserSelection(other.tag))
        {
            outputText.text = "";
        }
        else
        {
            if (other.tag != "")
            {
				//ItemsCollect.count = ItemsCollect.count - 20;
				//ItemsCollect.setCountText ();
                outputText.text = "Wrong selection";
                Debug.Log("Wrong selection");
            }

        }
    }

        bool checkUserSelection(string pipeSelected){
		if ("p1".CompareTo(pipeSelected)==0) {
			if (s1[0].gameObject.activeSelf ) {
				return false;
			} else {
				if (!(s2 [0].gameObject.activeSelf && s3 [0].gameObject.activeSelf && s4 [0].gameObject.activeSelf)) {
					s1[0].SetActive(true);
					p1[0].SetActive(false);
					return true;
				}
			}
			
		}

		if ("p2".CompareTo(pipeSelected)==0) {
			if (!s1[0].gameObject.activeSelf ) {
				return false;
			} else {
				if (!(  s3 [0].gameObject.activeSelf && s4 [0].gameObject.activeSelf)) {
					s2[0].SetActive(true);
					p2[0].SetActive(false);
					return true;
				}
			}

		}

		if ("p3".CompareTo(pipeSelected)==0) {
			if (!(s1[0].gameObject.activeSelf &&  s2[0].gameObject.activeSelf)) {
				return false;
			} else {
				if (!(s4 [0].gameObject.activeSelf)) {
					s3[0].SetActive(true);
					p3[0].SetActive(false);
					return true;
				}
			}

		}

		if ("p4".CompareTo(pipeSelected)==0) {
			if (!(s1[0].gameObject.activeSelf &&  s2[0].gameObject.activeSelf && s3[0].gameObject.activeSelf)) {
				return false;
			} else {
				
					s4[0].SetActive(true);
					p4[0].SetActive(false);
				    GetComponent<AudioSource> ().Play ();
				    return true;
			}

		}
		return false;
	}


}
