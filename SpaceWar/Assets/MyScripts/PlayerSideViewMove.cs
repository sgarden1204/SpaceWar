using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSideViewMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float moveZ = 100.0f;

    CharacterController player;

    Vector3 move;

	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(moveZ, ver * moveSpeed, hor * moveSpeed);

        player.Move(move * Time.deltaTime);
	}
}
