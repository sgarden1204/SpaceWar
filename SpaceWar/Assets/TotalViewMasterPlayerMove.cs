using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewMasterPlayerMove : MonoBehaviour {

    [SerializeField] float movementSpeed = 50.0f;
    [SerializeField] float turnSpeed = 60.0f;

    Transform playerPos;

	// Use this for initialization
	void Start () {
        playerPos = this.transform;
	}
	
	// Update is called once per frame
	void Update () {

        Turn();
        Thrust();
	}

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");

        playerPos.Rotate(-pitch, yaw, -roll);
    }

    void Thrust()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            playerPos.position += playerPos.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        }

        else
        {
            playerPos.position -= -playerPos.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        }
    }
}
