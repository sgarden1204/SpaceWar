using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossMissileBoom : MonoBehaviour
{

    GameObject playerpos;
    GameObject topLeftFire;

    private void Start()
    {
        playerpos = GameObject.Find("BackPlayerPos");
        topLeftFire = GameObject.Find("TopLeftFire");

    }

    private void Update()
    {
        if (topLeftFire == null)
        {
            Destroy(this.gameObject);
        }

        if (Vector3.Distance(this.transform.position, topLeftFire.transform.position) >= 50.0f)
        {
            Destroy(this.gameObject);
        }

        this.transform.LookAt(playerpos.transform);

        if (Stage4Manager.state == Stage4Manager.State.Top || Stage4Manager.state == Stage4Manager.State.Side)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Enemy" || other.tag == "Wall")
        //{
        //    Destroy(this.gameObject);
        //}

        if(other.tag == "BackPlayerPos")
        {
            Destroy(this.gameObject);
        }
    }
}