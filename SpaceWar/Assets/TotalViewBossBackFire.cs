using UnityEngine;
using System.Collections;

public class TotalViewBossBackFire : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;
    public float fireRate;
    public float delay = 3.0f;

    GameObject myBoss;
    
    void Start()
    {

    }

    private void Update()
    {
        delay += 60 * Time.deltaTime;

       // delay = (delay + 1) * Time.deltaTime;

        if (delay >= 120)
        {
            Fire();
            delay = 0;
        }

    }

void Fire()
    {
       Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
       GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
