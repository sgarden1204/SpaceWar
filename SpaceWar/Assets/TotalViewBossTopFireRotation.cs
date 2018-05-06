using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossTopFireRotation : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;

    public float delay = 3.0f;
    public float rotDelay = 3.0f;
    public float rotAngle = 90.0f;

    GameObject playerPos;

    private GameObject[] fiveShot = new GameObject[5];

    private void Start()
    {
        //playerPos = GameObject.Find("TopPlayer");
    }

    private void Update()
    {
        //this.transform.Rotate(0.0f, 0.0f, rotAngle * Time.deltaTime);

        delay += 60 * Time.deltaTime;

        // delay = (delay + 1) * Time.deltaTime;
        Debug.Log(delay);

        if (delay >= 90)
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
        fiveShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        fiveShot[0].transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

        fiveShot[1] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        fiveShot[1].transform.eulerAngles = new Vector3(0.0f, 30.0f, 0.0f);

        fiveShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        fiveShot[2].transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);

        fiveShot[3] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        fiveShot[3].transform.eulerAngles = new Vector3(0.0f, -30.0f, 0.0f);

        fiveShot[4] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        fiveShot[4].transform.eulerAngles = new Vector3(0.0f, -45.0f, 0.0f);

        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
