using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillshapoe : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 start;
    public Vector3 end;
    public Vector3 direction;
    public Vector3 spawn;
    float lenght;
    bool grav = true;
    public int shots = 0;
    // Use this for initialization
    void Start()
    {

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
                if (transform.position.y <= 2)
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

        if (this.transform.position.y < -50)
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
}
