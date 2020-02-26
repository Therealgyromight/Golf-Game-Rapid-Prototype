using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
    public GameObject player;
    private int distance = 10;
    Vector3 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = player.transform.position;
        pos.y += 10;
        pos.z -= 5;
        transform.position = pos;
	}
}
