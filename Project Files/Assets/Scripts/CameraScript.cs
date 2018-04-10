using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    Camera mycam;
    public float sensitivity = 0.05f;

    bool cameraUnlocked = false;
    bool oneLock = false;

    Vector3 originalCameraPos;
    Quaternion originalCameraRot;


    void Start () {
        mycam = GetComponent<Camera>();
        originalCameraPos = mycam.transform.localPosition;
        originalCameraRot = mycam.transform.localRotation;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire2"))
        {
            cameraUnlocked = !cameraUnlocked;
        }

        if ( cameraUnlocked )
        {
            oneLock = false;
            Vector3 vp = mycam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane));

            vp.x -= 0.5f;
            vp.y -= 0.5f;
            vp.x *= sensitivity;
            vp.y *= sensitivity;
            vp.x += 0.5f;
            vp.y += 0.5f;
            vp = mycam.ViewportToScreenPoint(vp);
            vp = mycam.ScreenToWorldPoint(vp);

            transform.LookAt(vp, Vector3.up);
        }
        else if( !cameraUnlocked && !oneLock)
        {
            mycam.transform.localPosition = originalCameraPos;
            mycam.transform.localRotation = originalCameraRot;
            oneLock = true;
        }

    }
}
