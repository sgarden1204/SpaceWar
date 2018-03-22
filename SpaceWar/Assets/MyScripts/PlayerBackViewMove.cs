using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBackViewMove : MonoBehaviour {

    public float moveSpeed = 5.0f;

    CharacterController controller;
    Vector3 move;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * moveSpeed, ver * moveSpeed, moveSpeed);

        controller.Move(move * Time.deltaTime);
	}
}
