using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {
    public GameObject shoulder;
    public Vector3 origin;
    // Use this for initialization
    void Start () {
        origin = GameObject.Find("Shoulder").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.I))
        {
            if( this.transform.rotation.z < 0.5)
            {
                transform.RotateAround(origin, Vector3.forward, 50 * Time.deltaTime);
            }         
        }

        else if (Input.GetKey(KeyCode.K))
        {
            if (this.transform.rotation.z > -0.5)
            {
                transform.RotateAround(origin, Vector3.forward, -50 * Time.deltaTime);
            }
        }

        else if(!Input.GetKey(KeyCode.K) && !Input.GetKey(KeyCode.I))
        {
            if(-0.51 < this.transform.rotation.z && this.transform.rotation.z < 0)
            {
                transform.RotateAround(origin, Vector3.forward, 50 * Time.deltaTime);
            }
            if (0 < this.transform.rotation.z && this.transform.rotation.z < 0.51)
            {
                transform.RotateAround(origin, Vector3.forward, -50 * Time.deltaTime);
            }
        }
    }
}
