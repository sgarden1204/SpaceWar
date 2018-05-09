using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeGamePlayerMove : MonoBehaviour
{
    public Slider shield;

    public static float moveSpeed = 10.0f;
    public static float rotSpeed = 120.0f;

    CharacterController controller;
    Vector3 moveVector;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            rotSpeed += 5.0f;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            rotSpeed -= 5.0f;
        }

        float amtRot = rotSpeed * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float ang = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * ang * amtRot);
        moveVector = new Vector3(0.0f, 0.0f, ver * moveSpeed);

        moveVector = this.transform.TransformDirection(moveVector);
        controller.Move(moveVector * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemyBullet")
        {
            shield.value -= 10.0f;
        }
    }
}
