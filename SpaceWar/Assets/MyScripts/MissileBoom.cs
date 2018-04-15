using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBoom : MonoBehaviour {

    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("PlayerPos");
    }

    private void Update()
    {
        if(Vector3.Distance(this.transform.position, playerpos.transform.position) >= 1000.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" || other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
