using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidetoside : MonoBehaviour {
    public Vector3 position1;
    public Vector3 position2;
    public int check;
	// Use this for initialization
	void Start () {
        this.transform.position = position1;
        check = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position == position1)
        {
            check = 1;
        }
        if (this.transform.position == position2)
        {
            check = 2;
        }

        if(check == 1)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position2, 0.1f);
        }

        if (check == 2)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, position1, 0.1f);
        }
    }
}
