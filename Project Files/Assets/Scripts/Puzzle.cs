using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    float realRotation;
	public int[] values;
	public float speed;

	void Update () {
		if (Input.GetMouseButton (0)) {
			transform.Rotate(Vector3.up , 90);
		}
	/*	if (transform.rotation.eulerAngles.z != realRotation) {
			transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.Euler (0, 0, realRotation), speed);
		}*/
	}

	void GetMouseButton()
	{
		Debug.Log ("on mouse down");
		transform.Rotate(Vector3.up* Time.deltaTime , 90);
		RotatePiece ();

	}

	public void RotatePiece()
	{
		realRotation += 90;

		if (realRotation == 360)
			realRotation = 0;

		RotateValues ();
	}



	public void RotateValues()
	{

		int aux = values [0];

		for (int i = 0; i < values.Length-1; i++) {
			values [i] = values [i + 1];
		}
		values [3] = aux;
	}

	void OnMouseUpAsButton()
	{
		Debug.Log ("OnMouseUpAsButton");
	/*	float rotX = Input.GetAxis ("Mouse X") * speed*Mathf.Deg2Rad;
		float rotY = Input.GetAxis ("Mouse Y") * speed*Mathf.Deg2Rad;
		//transform.Rotate(Vector3.right * Time.deltaTime);
		transform.Rotate(Vector3.up* Time.deltaTime , 90);
		//transform.Rotate(Vector3.right* Time.deltaTime , 90);
		//transform.Rotate (90);*/
	}

}
