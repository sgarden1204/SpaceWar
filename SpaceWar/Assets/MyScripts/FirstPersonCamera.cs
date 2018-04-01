using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {

    public Transform playerPos;

    public float moveSpeed = 20.0f;
    public float controllMoveSpeed = 20.0f;

    private Vector3 move;

    private void Start()
    {
        //this.transform.Rotate(15.0f, 0.0f, 0.0f);
    }

    void Update () {

        //this.transform.Translate(0.0f, 0.0f, 20.0f * Time.deltaTime);

        this.transform.position = playerPos.position;
        this.transform.position = new Vector3(playerPos.position.x, playerPos.position.y + 5.0f, playerPos.position.z - 3.0f);

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, moveSpeed);

        this.transform.Translate(move * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.0f);
        }
    }
}
