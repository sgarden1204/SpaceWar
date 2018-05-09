using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMissileBoom : MonoBehaviour
{

    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("PlayerPos");
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, playerpos.transform.position) >= 10000.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" || other.tag == "Wall" || other.tag == "asteroid")
        {
            Destroy(this.gameObject);
        }
    }
}
