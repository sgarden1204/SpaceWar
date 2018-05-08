using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewTopMissileBoom : MonoBehaviour
{
    public float distance = 30.0f;

    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("TopPlayerPos");
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
        if (other.tag == "Enemy" || other.tag == "Wall" || other.tag =="Boss")
        {
            Destroy(this.gameObject);
        }
    }
}