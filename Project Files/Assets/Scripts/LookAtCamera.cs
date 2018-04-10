using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {
	
	void Update () {
        Debug.Log("HelloWrold");
        transform.LookAt(GameObject.FindGameObjectWithTag("MainCamera").transform.position);
	}
}
