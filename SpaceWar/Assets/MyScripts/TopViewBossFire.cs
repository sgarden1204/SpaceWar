using UnityEngine;
using System.Collections;

public class TopViewBossFire : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;
    public float fireRate;
    public float delay = 3.0f;

    private GameObject[] threeShot = new GameObject[3];

    private GameObject playerPos;

    void Start()
    {
        playerPos = GameObject.Find("PlayerPos");
    }

    private void Update()
    {
        //this.transform.LookAt(playerPos.transform);

        delay += 60 * Time.deltaTime;

        if (delay >= fireRate)
        {
            Fire();
            delay = 0;
        }

    }

    void Fire()
    {
        //threeShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        //threeShot[0].transform.eulerAngles = new Vector3(0.0f, 220.0f, 0.0f);

        //threeShot[1] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        //threeShot[1].transform.eulerAngles = new Vector3(0.0f, 240.0f, 0.0f);

        threeShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        //threeShot[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z);

        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
