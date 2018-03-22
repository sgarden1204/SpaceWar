using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideCamera : MonoBehaviour {

    public Transform playerPos;

    Camera myCamera;

    public float distance = 10.0f;
	// Use this for initialization
	void Start () {
        myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        myCamera.transform.position = playerPos.transform.position;

        myCamera.transform.position = new Vector3(myCamera.transform.position.x + distance, myCamera.transform.position.y, myCamera.transform.position.z);
        //myCamera.transform.eulerAngles = new Vector3(0.0f, 90.0f, 0.0f);

        myCamera.transform.LookAt(playerPos);
	}
}
