using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBackViewMove : MonoBehaviour {

    public float moveSpeed = 20.0f;
    public float controllMoveSpeed = 20.0f;

    public Slider shild;

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
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 10000.0f);
        }
	}

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "asteroid" || other.tag == "enemybullet")
        {
            shild.value -= 10;

            if (shild.value <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        if(other.tag == "NextStage")
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
