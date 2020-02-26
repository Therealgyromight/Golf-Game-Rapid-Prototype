﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increases : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 start;
    public Vector3 end;
    public Vector3 direction;
    public Vector3 spawn;
    float lenght;
    bool grav = true;
    public int shots = 0;
    private Vector3 scaleChange;
    // Use this for initialization
    void Start()
    {
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            start = Input.mousePosition;
            start.z = start.y;
            start.y = 0;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            shots++;
            end = Input.mousePosition;
            end.z = end.y;
            end.y = 0;
            direction = end - start;
            lenght = direction.magnitude;

            if (grav == true)
            {
                if (transform.position.y <= this.transform.localScale.x)
                {
                    rb.AddForce(0, lenght, 0);
                    rb.AddForceAtPosition(-direction, start);
                }
            }
            else
            {
                rb.AddForce(0, lenght, 0);
                rb.AddForceAtPosition(-direction, start);
            }

        }

        if (this.transform.position.y < -5)
        {
            this.transform.position = spawn;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            print("Win");
        }
        if (collision.gameObject.tag == "EditorOnly")
        {
            grav = false;
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            if(this.transform.localScale.x >= 5)
            {

            }
            else
            {
                this.transform.localScale += scaleChange;
            }
            
        }
    }
}