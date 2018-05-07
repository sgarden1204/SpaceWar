using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModGamePlayerMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public Slider shield;

    CharacterController player;
    Vector3 move;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            moveSpeed += 1.0f;
        }

        if(Input.GetKeyUp(KeyCode.S))
        {
            moveSpeed -= 1.0f;
        }

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * moveSpeed, 0.0f, ver * moveSpeed);

        player.Move(move * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid" || other.tag == "Mine")
        {
            shield.value -= 10;
        }
    }
}
