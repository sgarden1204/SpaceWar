using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPlayerMove : MonoBehaviour {

    CharacterController controller;
    Vector3 move;

    public float controllMoveSpeed = 10.0f;

    void Start () {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, 0.0f);

        controller.Move(move * Time.deltaTime);
    }
}
