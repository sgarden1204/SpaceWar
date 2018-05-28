using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewMasterPlayerMove : MonoBehaviour {

    [SerializeField] float movementSpeed = 50.0f;
    [SerializeField] float turnSpeed = 60.0f;
    [SerializeField] float rotationSpeed = 1.0f;

    public Text battleArea;
    public Slider shield;
    public AudioClip brokenShield;
    public GameObject playerDestroy;
    public AudioClip destroyClip;

    Transform playerPos;

	// Use this for initialization
	void Start () {
        playerPos = this.transform;
	}
	
	// Update is called once per frame
	void Update () {

        Turn();
        Thrust();
        ResetCase();

        if(Input.GetKeyUp(KeyCode.Alpha9))
        {
            shield.value -= 9999.0f;
        }
	}

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch") * rotationSpeed;
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll") * rotationSpeed;

        playerPos.Rotate(-pitch, yaw, -roll);
    }

    void Thrust()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            playerPos.position += playerPos.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        }

        else
        {
            playerPos.position -= -playerPos.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        }
    }

    void TransformReset()
    {
        battleArea.gameObject.SetActive(true);
        this.transform.position = new Vector3(0.0f, 0.0f, 100.0f);
        this.transform.eulerAngles = new Vector3(0.0f, 180.0f, 0.0f);
        Invoke("Sec", 2.0f);
    }

    void ResetCase()
    {
        //R버튼 누르면 위치 리셋
        if (Input.GetKeyUp(KeyCode.R))
        {
            TransformReset();
        }

        //Front,Back Position Reset
        if(this.transform.position.z <= 65.0f || this.transform.position.z >= 200.0f)
        {
            TransformReset();
        }

        if (this.transform.position.x >= 65.0f || this.transform.position.x <= -65.0f)
        {
            TransformReset();
        }

        if(this.transform.position.y >= 65.0f || this.transform.position.y <= -65.0f)
        {
            TransformReset();
        }

    //    if (this.transform.position.z <= 65.0f || this.transform.position.z >= 200.0f
    //|| this.transform.position.x >= 65.0f || this.transform.position.x <= -65.0f
    //|| this.transform.position.y >= 65.0f || this.transform.position.y <= -65.0f)
    //    {

    //    }


    }

    void Sec()
    {
        battleArea.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBullet")
        {
            shield.value -= 1.0f;
            GetComponent<AudioSource>().PlayOneShot(brokenShield);
            EZCameraShake.CameraShaker.Instance.ShakeOnce(2.0f, 2.0f, 1.0f, 1.0f);

            if (shield.value <= 0)
            {
                GetComponent<AudioSource>().PlayOneShot(destroyClip);
                Instantiate(playerDestroy, this.transform.position, this.transform.rotation);
                Invoke("GameOver", 2.0f);
            }
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
