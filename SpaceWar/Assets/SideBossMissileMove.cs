using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBossMissileMove : MonoBehaviour {

    public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
