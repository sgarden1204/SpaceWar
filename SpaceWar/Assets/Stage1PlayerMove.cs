using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1PlayerMove : MonoBehaviour {

    public float controllMoveSpeed = 10.0f;
    public float controllRotSpeed = 120.0f;

    CharacterController controller;
    Vector3 move;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //float amtRot = controllRotSpeed * Time.deltaTime;
        //float ver = Input.GetAxis("Vertical");
        //float hor = Input.GetAxis("Horizontal");

        //this.transform.Rotate(Vector3.up * hor * amtRot);


        float rotLR = controllRotSpeed * Time.deltaTime;
        float rotTB = controllRotSpeed / 3.0f * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * hor * rotLR);
        this.transform.Rotate(Vector3.left * ver * rotLR);

        move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, 0.0f);
        move = this.transform.TransformDirection(move);

        controller.Move(move * Time.deltaTime);
    }
}
