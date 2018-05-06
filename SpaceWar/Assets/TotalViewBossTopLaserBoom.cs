using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossTopLaserBoom : MonoBehaviour
{

    public float distance = 50.0f;

    GameObject playerpos;
    GameObject TopMidFire;

    private void Start()
    {
        playerpos = GameObject.Find("TopPlayerPos");
        TopMidFire = GameObject.Find("TopMidFire");

    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, TopMidFire.transform.position) >= distance)
        {
            Destroy(this.gameObject);
        }

        if (Stage4Manager.state == Stage4Manager.State.Back || Stage4Manager.state == Stage4Manager.State.Side)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TopPlayerPos")
        {
            Destroy(this.gameObject);
        }
    }
}