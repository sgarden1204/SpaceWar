using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewPlayerSideMove : MonoBehaviour
{
    public Slider shield;
    public int damage = 2;
    public float moveSpeed = 10.0f;

    public AudioClip ziziziClip;
    public AudioClip brokenShield;
    public AudioClip destroyClip;

    public GameObject playerDestroy;
    public GameObject playerSpark;

    public Text captured;

    CharacterController controller;
    Vector3 moveVector;

    public float highSpeed = 5.0f;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // x 45 아래 위
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, -60.0f);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, -120.0f);
        }

        else
        {
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f, -90.0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            moveVector = new Vector3(-hor * moveSpeed * 1.5f, ver * moveSpeed, -1.0f * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.E))
        {
            moveVector = new Vector3(-hor * moveSpeed * 1.5f, ver * moveSpeed, 1.0f * moveSpeed);
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            moveVector = new Vector3(-hor * moveSpeed * highSpeed, ver * moveSpeed * highSpeed, 0.0f);
        }

        else
        {
            moveVector = new Vector3(0.0f, ver * moveSpeed * 1.5f, -hor * moveSpeed);
        }

        controller.Move(moveVector * Time.deltaTime);

        if(this.transform.position.z <= 74.0f)
        {
            GetComponent<AudioSource>().PlayOneShot(ziziziClip);
            Instantiate(playerSpark, this.transform.position, this.transform.rotation);
        }

        if(this.transform.position.y <= -11.0f)
        {
            captured.gameObject.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(brokenShield);
            EZCameraShake.CameraShaker.Instance.ShakeOnce(3.0f, 3.0f, 1.0f, 1.0f);
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 7.0f, this.transform.position.z);
            Invoke("Sec", 3.0f);
        }

        if(this.transform.position.y >= 6.0f)
        {
            captured.gameObject.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(brokenShield);
            EZCameraShake.CameraShaker.Instance.ShakeOnce(3.0f, 3.0f, 1.0f, 1.0f);
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 7.0f, this.transform.position.z);
            Invoke("Sec", 3.0f);
        }

        if(this.transform.position.z >= 100.0f)
        {
            captured.gameObject.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(brokenShield);
            EZCameraShake.CameraShaker.Instance.ShakeOnce(3.0f, 3.0f, 1.0f, 1.0f);
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 10.0f);
            Invoke("Sec", 3.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBullet")
        {
            shield.value -= damage;

            if (shield.value <= 0)
            {
                GetComponent<AudioSource>().PlayOneShot(destroyClip);
                Instantiate(playerDestroy, this.transform.position, this.transform.rotation);
                Invoke("GameOver", 2.0f);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "EnemyBullet")
        {
            GetComponent<AudioSource>().PlayOneShot(ziziziClip);
            Instantiate(playerSpark, this.transform.position, this.transform.rotation);
        }
    }

    public void GameOver()
    {
        if (ScoreManager.Instance() != null)
        {
            ScoreManager.Instance().ScoreSave();
        }

        SceneManager.LoadScene("Result");
    }

    public void Sec()
    {
        captured.gameObject.SetActive(false);
    }
}
