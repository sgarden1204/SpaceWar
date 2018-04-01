using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBackViewMove : MonoBehaviour {

    public float moveSpeed = 20.0f;
    public float controllMoveSpeed = 20.0f;

    CharacterController controller;
    Vector3 move;

    //public static move

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, moveSpeed);

        controller.Move(move * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.0f);
        }
	}
}
