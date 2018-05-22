using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopViewPlayerMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public Slider shield;
    public GameObject hitSpark;
    public GameObject itemCollect;
    public GameObject playerDestroy;

    public AudioClip sparkCilp;
    public AudioClip playerHitClip;
    public AudioClip MineExplosion;

    public AudioClip shieldCilp;
    public AudioClip lCClip;
    public AudioClip scoreClip;
    public AudioClip powerUpClip;

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

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        move = new Vector3(hor * moveSpeed, 0.0f, ver * moveSpeed);

        player.Move(move * Time.deltaTime);

        if(this.transform.position.x <= -20.0f || this.transform.position.x >= 20.0f || this.transform.position.z >= 30.0f || this.transform.position.z <= -2.0f)
        {
            shield.value--;
            Instantiate(hitSpark, this.transform.position, this.transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(sparkCilp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid" || other.tag == "Mine" || other.tag == "EnemyBullet")
        {
            shield.value -= 2;
            EZCameraShake.CameraShaker.Instance.ShakeOnce(2.5f, 2.5f, 1.0f, 1.0f);
            GetComponent<AudioSource>().PlayOneShot(playerHitClip);

            if(other.tag == "Mine")
                GetComponent<AudioSource>().PlayOneShot(MineExplosion,0.5f);

            if (shield.value <= 0)
            {
                Instantiate(playerDestroy,this.transform.position,this.transform.rotation);
                Invoke("GameOver", 2.5f);
            }
        }

        if(other.tag == "ItemPowerUp")
        {
            GetComponent<AudioSource>().PlayOneShot(powerUpClip);
            Instantiate(itemCollect, this.transform.position, this.transform.rotation);
            
        }

        if (other.tag == "LCItem")
        {
            GetComponent<AudioSource>().PlayOneShot(lCClip);
        }

        if (other.tag == "ShieldItem")
        {
            GetComponent<AudioSource>().PlayOneShot(shieldCilp, 1.0f);
            Instantiate(itemCollect, this.transform.position, this.transform.rotation);
        }

        if (other.tag == "ScoreItem")
        {
            GetComponent<AudioSource>().PlayOneShot(scoreClip);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Core")
        {
            shield.value--;
            Instantiate(hitSpark, this.transform.position, this.transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(sparkCilp);
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
}
