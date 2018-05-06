using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage4Manager : MonoBehaviour
{
    public Camera backCamera;
    public Camera topCamera;
    public Camera sideCamera;

    public GameObject backPlayer;
    public GameObject topPlayer;
    public GameObject sidePlayer;

    public GameObject backBoss;
    public GameObject topBoss;
    public GameObject sideBoss;

    public GameObject[] sideEnemy = new GameObject[2];

    public enum State
    {
        Top,Side,Back
    };

    public static State state = State.Back;

    //public static Text ViewChangeText;
    public Text changeText;

    public AudioClip clip;

    public Image bulletImg;
    public Sprite raser;
    public Sprite missile;
    public Sprite machinegun;

    private int weaponChange = 0;

    // Use this for initialization
    void Start()
    {
        backCamera.enabled = true;
        topCamera.enabled = false;
        sideCamera.enabled = false;

        topPlayer.SetActive(false);
        sidePlayer.SetActive(false);
        backPlayer.SetActive(true);

        topBoss.SetActive(false);
        sideBoss.SetActive(false);
        backBoss.SetActive(true);

        //AudioManager.Instance().PlayClip(clip);

        //if(AudioManager.Instance() == null)
        //{

        //}

        GetComponent<AudioSource>().PlayOneShot(clip, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            switch (weaponChange)
            {
                case 0:
                    bulletImg.sprite = raser;
                    weaponChange++;
                    break;
                case 1:
                    bulletImg.sprite = machinegun;
                    weaponChange++;
                    break;
                case 2:
                    bulletImg.sprite = missile;
                    weaponChange = 0;
                    break;
            }
        }


        if (Input.GetKey(KeyCode.X))
        {
            //topCamera = Camera.main;
            topCamera.enabled = false;
            sideCamera.enabled = false;
            backCamera.enabled = true;

            topPlayer.SetActive(false);
            sidePlayer.SetActive(false);
            backPlayer.SetActive(true);

            topBoss.SetActive(false);
            sideBoss.SetActive(false);
            backBoss.SetActive(true);

            changeText.text = "BACK";
            state = State.Back;

            sideEnemy[0].SetActive(false);
            sideEnemy[1].SetActive(false);
        }

        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.UpArrow))
        {
            topCamera.enabled = true;
            sideCamera.enabled = false;
            backCamera.enabled = false;

            topPlayer.SetActive(true);
            sidePlayer.SetActive(false);
            backPlayer.SetActive(false);

            topBoss.SetActive(true);
            sideBoss.SetActive(false);
            backBoss.SetActive(false);

            changeText.text = "TOP";
            state = State.Top;

            sideEnemy[0].SetActive(false);
            sideEnemy[1].SetActive(false);
        }

        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.LeftArrow))
        {
            //topCamera = Camera.main;
            topCamera.enabled = false;
            sideCamera.enabled = true;
            backCamera.enabled = false;

            topPlayer.SetActive(false);
            sidePlayer.SetActive(true);
            backPlayer.SetActive(false);

            topBoss.SetActive(false);
            sideBoss.SetActive(true);
            backBoss.SetActive(false);

            changeText.text = "SIDE";
            state = State.Side;

            sideEnemy[0].SetActive(true);
            sideEnemy[1].SetActive(true);
        }
    }
}