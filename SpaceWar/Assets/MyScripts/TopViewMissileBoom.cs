using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewMissileBoom : MonoBehaviour {


    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("PlayerPos");
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, playerpos.transform.position) >= 50.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Core" || other.tag == "Asteroid" || other.tag == "Mine")
        {
            Destroy(this.gameObject);
        }
    }
}
