using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModGameLaserFire : MonoBehaviour
{

    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;

    public float delay = 3.0f;
    public float fireDelay = 60.0f;

    GameObject playerPos;

    private GameObject LaserShot;

    private void Start()
    {

    }

    private void Update()
    {
        //this.transform.Rotate(0.0f, 0.0f, rotAngle * Time.deltaTime);

        delay += 60 * Time.deltaTime;

        // delay = (delay + 1) * Time.deltaTime;

        if (delay >= fireDelay)
        {
            Fire();
            delay = 0;
        }

        playerPos = GameObject.Find("TopPlayer");

        if (playerPos != null)
        {
            this.transform.LookAt(playerPos.transform);
        }
    }

    void Fire()
    {
        float randomValue = Random.Range(-90, 90);

        LaserShot = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        LaserShot.transform.eulerAngles = new Vector3(0.0f,0.0f , 0.0f);

        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
