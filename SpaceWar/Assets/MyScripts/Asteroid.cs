using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    public float moveSpeed = -10.0f;
    public float rot = 45.0f;

	// Use this for initialization
	void Start () {

        transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * rot * Time.deltaTime);
	}
}
