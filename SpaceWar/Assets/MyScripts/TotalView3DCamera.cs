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
        this.transform.eulerAngles = new Vector3(playerPos.rotation.x, 180.0f, playerPos.rotation.z);

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    // x 45 아래 위
        //    this.transform.eulerAngles = new Vector3(0.0f, 180.0f, 30.0f);
        //}

        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.eulerAngles = new Vector3(0.0f, 180.0f, -30.0f);
        //}

        //else if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    this.transform.eulerAngles = new Vector3(-30.0f, 180.0f, 0.0f);
        //}

        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    this.transform.eulerAngles = new Vector3(45.0f, 180.0f, 0.0f);
        //}

        //else
        //{
        //    this.transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
        //}

        //this.transform.LookAt(playerPos);
    }
}
