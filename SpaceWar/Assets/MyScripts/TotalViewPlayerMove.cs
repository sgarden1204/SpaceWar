using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewPlayerMove : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    CharacterController controller;
    Vector3 moveVector;

    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        float amtRot = rotSpeed * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float ang = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * ang * amtRot);

        moveVector = new Vector3(0.0f, 0.0f, ver * moveSpeed);
        moveVector = this.transform.TransformDirection(moveVector);

        if(Input.GetKey(KeyCode.Space))
        {
            moveVector.y = jumpSpeed;
        }

        if(Input.GetKey(KeyCode.Q))
        {
            moveVector.y = jumpSpeed;
        }

        if(Input.GetKey(KeyCode.E))
        {
            moveVector.y = -jumpSpeed;
        }

        moveVector.y -= gravity * Time.deltaTime;

        controller.Move(moveVector * Time.deltaTime);
	}
}
