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
    public Text wrongWay;
    public AudioClip hitSound;
    public AudioClip wrongWayClip;

    CharacterController controller;
    Vector3 move;

    //public static move

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        //EZCameraShake.CameraShaker.Instance.ShakeOnce(5.0f, 5.0f, 1.0f, 1.0f);

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

        if(this.transform.position.x <= -18000.0f || this.transform.position.x >= 18000.0f || this.transform.position.y <= -10000.0f || this.transform.position.y >= 10000.0f || this.transform.position.z <= -55000.0f)
        {
            wrongWay.gameObject.SetActive(true);
            this.transform.position = new Vector3(0.0f, 0.0f, -50000.0f);
            this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            move = this.transform.TransformDirection(move);
            GetComponent<AudioSource>().PlayOneShot(wrongWayClip);
            Invoke("Sec", 1.5f);
        }
	}

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "asteroid" || other.tag == "enemybullet")
        {
            shild.value -= 10;

            EZCameraShake.CameraShaker.Instance.ShakeOnce(5.0f, 5.0f, 1.0f, 1.0f);
            GetComponent<AudioSource>().PlayOneShot(hitSound);

            if (shild.value <= 0)
            {
                if (ScoreManager.Instance() != null)
                {
                    ScoreManager.Instance().ScoreSave();
                }
                SceneManager.LoadScene("Result");
            }
        }

        //if(other.tag == "NextStage")
        //{
        //    SceneManager.LoadScene("Stage2");
        //}

        //if(other.tag == "ResetWall")
        //{

        //}
    }

    public void Sec()
    {
        wrongWay.gameObject.SetActive(false);
    }
}
