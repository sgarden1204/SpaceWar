using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopViewItemPowerUp : MonoBehaviour
{

    //public Image[] showImg = new Image[3];

    public float downSpeed = 1.0f;

    public float posZ = 50.0f;
    float posX = 0;
    Vector3 vector3DownPos;

    // Use this for initialization
    void Start()
    {
        //pos = Random.Range(35, 100);
        //this.transform.position = new Vector3(0.0f, 0.0f, pos * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, posZ);
        posZ -= downSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            posZ = Random.Range(100.0f, 200.0f);
            posX = Random.Range(-30.0f, 30.0f);
            this.transform.position = new Vector3(posX, 0.0f, posZ);
        }

        if (other.tag == "ResetWall")
        {

            posZ = Random.Range(35, 100);
            posX = Random.Range(-20.0f, 20.0f);
            this.transform.position = new Vector3(posX, 0.0f, posZ);
        }

    }
}
