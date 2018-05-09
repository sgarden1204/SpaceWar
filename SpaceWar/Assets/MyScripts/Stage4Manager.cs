using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage4Manager : MonoBehaviour
{
    public GameObject[] deleteTopBoss = new GameObject[3];
    public GameObject[] deleteSideBoss = new GameObject[6];
    //public GameObject[] deleteBackBoss = new GameObject[3];

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

    public GameObject boom;
    private GameObject[] boomPos = new GameObject[4];
    public float boomPosValue = 20.0f;

    private bool topDie = false;
    private bool sideDie = false;

    public Slider bossHp;

    public enum State
    {
        Top,Side,Back
    };

    public static State state = State.Back;

    //public static Text ViewChangeText;
    public Text changeText;
    public Text scoreText;

    public AudioClip clip;

    public Image bulletImg;
    public Sprite raser;
    public Sprite missile;
    public Sprite machinegun;

    private int weaponChange = 0;

    private bool esc;

    // Use this for initialization
    void Start()
    {
        esc = true;
        backCamera.enabled = true;
        topCamera.enabled = false;
        sideCamera.enabled = false;

        topPlayer.SetActive(false);
        sidePlayer.SetActive(false);
        backPlayer.SetActive(true);

        topBoss.SetActive(false);
        sideBoss.SetActive(false);
        backBoss.SetActive(true);

        if (AudioManager.Instance() != null)
        {
            AudioManager.Instance().PlayClip(clip);
        }

        else
            GetComponent<AudioSource>().PlayOneShot(clip, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.Instance() != null)
        {
            scoreText.text = ScoreManager.score.ToString("D8");
        }

        if(bossHp.value <= 2250 && topDie == false)
        {
            deleteTopBoss[0].gameObject.SetActive(false);
            deleteTopBoss[1].gameObject.SetActive(false);
            deleteTopBoss[2].gameObject.SetActive(false);
            TopExplosion();
            topDie = true;
        }

        if(bossHp.value <= 1500 && sideDie == false)
        {
            deleteSideBoss[0].gameObject.SetActive(false);
            deleteSideBoss[1].gameObject.SetActive(false);
            deleteSideBoss[2].gameObject.SetActive(false);
            deleteSideBoss[3].gameObject.SetActive(false);
            deleteSideBoss[4].gameObject.SetActive(false);
            deleteSideBoss[5].gameObject.SetActive(false);
            SideExplosion();
            sideDie = true;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (esc)
            {
                Time.timeScale = 0.0f;
                esc = false;
            }

            else
            {
                Time.timeScale = 1.0f;
                esc = true;
            }
        }

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
            changeText.color = Color.red;
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
            changeText.color = Color.blue;
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
            changeText.color = Color.yellow;
            state = State.Side;

            sideEnemy[0].SetActive(true);
            sideEnemy[1].SetActive(true);
        }
    }

    public void TopExplosion()
    {
        boomPos[0] = Instantiate(boom);
        boomPos[0].transform.position = new Vector3(this.transform.position.x, this.transform.position.y + boomPosValue, this.transform.position.z + boomPosValue * 3);

        boomPos[1] = Instantiate(boom);
        boomPos[1].transform.position = new Vector3(this.transform.position.x + boomPosValue / 2.0f, this.transform.position.y + boomPosValue, this.transform.position.z + boomPosValue * 3);

        boomPos[2] = Instantiate(boom);
        boomPos[2].transform.position = new Vector3(this.transform.position.x - boomPosValue / 2.0f, this.transform.position.y + boomPosValue, this.transform.position.z + boomPosValue * 3);
    }

    public void SideExplosion()
    {
        boomPos[0] = Instantiate(boom);
        boomPos[0].transform.position = new Vector3(this.transform.position.x + boomPosValue, this.transform.position.y + boomPosValue, this.transform.position.z + boomPosValue / 2.0f);

        boomPos[1] = Instantiate(boom);
        boomPos[1].transform.position = new Vector3(this.transform.position.x + boomPosValue, this.transform.position.y - boomPosValue, this.transform.position.z + boomPosValue / 2.0f);

        boomPos[2] = Instantiate(boom);
        boomPos[2].transform.position = new Vector3(this.transform.position.x - boomPosValue, this.transform.position.y + boomPosValue, this.transform.position.z - boomPosValue / 2.0f);

        boomPos[3] = Instantiate(boom);
        boomPos[3].transform.position = new Vector3(this.transform.position.x - boomPosValue, this.transform.position.y - boomPosValue, this.transform.position.z - boomPosValue / 2.0f);
    }
}