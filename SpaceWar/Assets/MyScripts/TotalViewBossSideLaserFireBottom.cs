using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossSideLaserFireBottom : MonoBehaviour
{

    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;

    public float delay = 3.0f;
    public float fireDelay = 120.0f;

    public float angle = 15.0f;

    private GameObject[] LaserShot = new GameObject[3];

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
    }

    void Fire()
    {
        int randomValue = Random.Range(0, 8);

        switch (randomValue)
        {
            case 1: // left

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[0].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x - 75.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);
                break;

            case 2: // mid

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

                break;

            case 3: // right
                LaserShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[2].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x + 252.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                break;

            case 4: // left,mid

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[0].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x - 75.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                LaserShot[1] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

                break;

            case 5: // mid,right

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

                LaserShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[2].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x + 252.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                break;

            case 6: // left,right

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[0].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x - 75.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                LaserShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[2].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x + 252.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                break;

            default: // 7 left,mid,right

                LaserShot[0] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[0].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x - 75.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);

                LaserShot[1] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

                LaserShot[2] = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                LaserShot[2].transform.eulerAngles = new Vector3(shotSpawn.transform.rotation.x + 252.0f, shotSpawn.transform.rotation.y, shotSpawn.transform.rotation.z);
                break;
        }

        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
