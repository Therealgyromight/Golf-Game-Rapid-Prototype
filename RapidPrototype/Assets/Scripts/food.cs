using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {
    Vector3 goal;
    Vector3 start;
    // Use this for initialization
    void Start()
    {
        start = this.transform.position;
        
        goal = new Vector3(Random.Range(-28, 28), 1, Random.Range(-16, 39));
    }
	// Update is called once per frame
	void Update () {
        start = this.transform.position;
        if(this.transform.position.x == goal.x && this.transform.position.z == goal.z)
        {
            goal = new Vector3(Random.Range(-28, 28), 1, Random.Range(-16, 39));
        }
        else
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, goal, 0.1f);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere" && collision.gameObject.transform.localScale.x > this.transform.transform.localScale.x)
        {
            Destroy(gameObject);
        }
    }
}
