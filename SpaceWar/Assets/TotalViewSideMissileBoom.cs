using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewSideMissileBoom : MonoBehaviour
{
    public float distance = 25.0f;

    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("SidePlayerPos");
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, playerpos.transform.position) >= distance)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" || other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}