using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotalViewShipFireAni : MonoBehaviour
{

    public GameObject Laser;

    private GameObject LaserPos;
    // Use this for initialization
    void Start()
    {
        LaserPos = Instantiate(Laser, this.transform.position, this.transform.rotation);
        LaserPos.transform.eulerAngles = new Vector3(0.0f, 90.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
