using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour {

    public Transform playerPos;
    public float distance = 10.0f;
    Camera myCamera;

	// Use this for initialization
	void Start () {
        myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        myCamera.transform.position = new Vector3(playerPos.position.x, playerPos.position.y, playerPos.position.z - distance);
        transform.LookAt(playerPos);
        
	}
}
