using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopViewItemShield : MonoBehaviour {

    public Slider sliderShield;
    public float downSpeed = 1.0f;

    float posZ = 50.0f;
    float posX = 0;
    Vector3 vector3DownPos;

	// Use this for initialization
	void Start () {
        //pos = Random.Range(35, 100);
        //this.transform.position = new Vector3(0.0f, 0.0f, pos * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {

        this.transform.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, posZ);
        posZ -= downSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            sliderShield.value += 300;
            posZ = Random.Range(100.0f, 500.0f);
            posX = Random.Range(-20.0f, 20.0f);
            this.transform.position = new Vector3(posX*Time.deltaTime, 0.0f, posZ * Time.deltaTime);
        }

        if(other.tag == "ResetWall")
        {

            posZ = Random.Range(35, 100);
            posX = Random.Range(-20.0f, 20.0f);
            this.transform.position = new Vector3(posX * Time.deltaTime, 0.0f, posZ * Time.deltaTime);
        }

    }
}
