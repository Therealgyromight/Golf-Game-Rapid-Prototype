using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathwall : MonoBehaviour {
    Vector3 position;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        position = this.transform.position;
        position.z = position.z + 0.02f;
        this.transform.position = position;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            UnityEditor.SceneManagement.EditorSceneManager.LoadScene(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene().buildIndex);
        }
    }
}
