using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBackViewMove : MonoBehaviour {

    public float moveSpeed = 20.0f;
    public float controllMoveSpeed = 20.0f;
    public float cameraRotSpeed = 120.0f;

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
        float amtRot = cameraRotSpeed * Time.deltaTime;

        this.transform.Rotate(Vector3.up * hor * amtRot);

        move = new Vector3(0.0f, ver * controllMoveSpeed, moveSpeed);
        move = this.transform.TransformDirection(move);

        controller.Move(move * Time.deltaTime);

        if(Input.GetKeyUp(KeyCode.Alpha0))
        {
            ScoreManager.Instance().ScoreSave();
            SceneManager.LoadScene("Result");
        }
	}

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "asteroid" || other.tag == "enemybullet")
        {
            shild.value -= 10;

            if (shild.value <= 0)
            {
                ScoreManager.Instance().ScoreSave();
                SceneManager.LoadScene("Result");
            }
        }

        if(other.tag == "NextStage")
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
