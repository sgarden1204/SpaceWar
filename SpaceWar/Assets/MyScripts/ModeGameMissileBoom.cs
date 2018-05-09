using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeGameMissileBoom : MonoBehaviour
{
    public float distance = 50.0f;

    GameObject playerpos;

    private void Start()
    {
        playerpos = GameObject.Find("PlayerPos");
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
        if (other.tag == "Enemy" || other.tag == "EnemyBullet")
        {
            Destroy(this.gameObject);
        }
    }
}
