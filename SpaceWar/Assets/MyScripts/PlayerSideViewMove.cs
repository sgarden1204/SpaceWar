using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSideViewMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    //public float moveZ = 100.0f;
    public Slider shield;

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

        move = new Vector3(0.0f, ver * moveSpeed * 2.5f, hor * moveSpeed);

        player.Move(move * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall" || other.tag == "Enemy")
        {
            shield.value -= 10;

            if(shield.value <= 0)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}
