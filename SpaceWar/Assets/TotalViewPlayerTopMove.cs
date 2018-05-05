﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewPlayerTopMove : MonoBehaviour
{

    public float moveSpeed = 10.0f;

    CharacterController controller;
    Vector3 moveVector;

    public float highSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // x 45 아래 위
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, 30.0f);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, -30.0f);
        }

        else
        {
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            moveVector = new Vector3(-hor * moveSpeed * 1.5f, ver * moveSpeed, -1.0f * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.E))
        {
            moveVector = new Vector3(-hor * moveSpeed * 1.5f, ver * moveSpeed, 1.0f * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            moveVector = new Vector3(-hor * moveSpeed * highSpeed, ver * moveSpeed * highSpeed, 0.0f);
        }

        else
        {
            moveVector = new Vector3(-hor * moveSpeed * 1.5f, 0.0f, -ver * moveSpeed);
        }

        controller.Move(moveVector * Time.deltaTime);
    }
}
