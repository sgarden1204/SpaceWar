using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalView3DCamera : MonoBehaviour {

    public Transform playerPos;
    public float yPos = 1.0f;
    public float xPos = 1.0f;
    public float zPos = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = new Vector3(playerPos.position.x + xPos, playerPos.position.y + yPos, playerPos.position.z + zPos);
        this.transform.LookAt(playerPos);
	}
}
