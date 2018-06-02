using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSideViewMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    //public float moveZ = 100.0f;
    public Slider shield;

    public GameObject spark;
    public GameObject playerBoom;

    public AudioClip sparkclip;
    public AudioClip explosionClip;
    public AudioClip playerExplosionClip;

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

        if (this.transform.position.y >= 38.0f || this.transform.position.y <= -38)
        {
            //EZCameraShake.CameraShaker.Instance.ShakeOnce(5.0f, 1.0f, 1.0f, 1.0f);
            GetComponent<AudioSource>().PlayOneShot(sparkclip);
            //this.transform.position = new Vector3(0.0f, 0.0f, this.transform.position.z);
            Instantiate(spark, this.transform.position, this.transform.rotation);
            shield.value--;

            if (shield.value <= 0)
            {
                if (ScoreManager.Instance() != null)
                {
                    ScoreManager.Instance().ScoreSave();
                }

                SceneManager.LoadScene("Result");
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall" || other.tag == "Enemy")
        {
            shield.value -= 10;
            EZCameraShake.CameraShaker.Instance.ShakeOnce(10.0f, 5.0f, 1.0f, 1.0f);
            //GetComponent<AudioSource>().PlayOneShot(explosionClip);
            if (shield.value <= 0)
            {
                if (ScoreManager.Instance() != null)
                {
                    ScoreManager.Instance().ScoreSave();
                }
                GetComponent<AudioSource>().PlayOneShot(playerExplosionClip);
                Instantiate(playerBoom, this.transform.position, this.transform.rotation);
                Invoke("GameOver", 3.0f);
            }
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Result");
    }
}
