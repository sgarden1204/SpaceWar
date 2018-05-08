using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewBossMissileBoom : MonoBehaviour
{
    GameObject BossPos;

    private void Start()
    {
        BossPos = GameObject.Find("Core");
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, BossPos.transform.position) >= 50.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "SuperPlayerLaser")
        {
            Destroy(this.gameObject);
        }
    }
}