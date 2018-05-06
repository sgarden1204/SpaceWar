using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewCoreRotation : MonoBehaviour {

    public float rotateSpeed = 90.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0.0f, 0.0f, rotateSpeed * Time.deltaTime);
	}
}
