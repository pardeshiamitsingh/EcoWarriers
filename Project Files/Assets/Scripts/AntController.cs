using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AntController : MonoBehaviour {

	public Transform target;
	float speed = 0.3f;

	Vector3 originalpos;

	void Start()
	{
		originalpos = transform.position;
	}

	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		float dist = Vector3.Distance (transform.position, target.position);
		if (dist < 2.0f) 
		{
			this.transform.position = originalpos;
		}
	}
}
