using UnityEngine;
using System.Collections;

public class TopViewREnemy : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public AudioClip clip;
    public float fireRate;
    public float delay;

    void Start()
    {
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
