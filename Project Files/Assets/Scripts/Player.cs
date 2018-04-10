using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody m_Rigidbody;
    public float m_Speed = 2;
    public float side_ways_speed = 5;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    void Update () {
      /*  float moveHr = Input.GetAxis("Horizontal");
        float moveVr = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHr, 0.0f, moveVr);
        rb.AddForce(movement * speed);
        if (Input.GetButtonDown("Horizontal"))
        {
          transform.localPosition += Input.GetAxis("Horizontal")* transform.right * Time.deltaTime * speed;
        }

        if (Input.GetButtonDown("Vertical"))
        {
            transform.localPosition += Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * speed;
        }
        */

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, side_ways_speed, 0) * Time.deltaTime * m_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -side_ways_speed, 0) * Time.deltaTime * m_Speed, Space.World);
        }
    }
}
