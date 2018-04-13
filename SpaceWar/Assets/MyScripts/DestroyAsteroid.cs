using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour {

    public float life = 100.0f;

    public GameObject explosion;

    private AudioSource audioDestroy;
    private GameObject exp;


    public float lifetime = 1.5f;

    private void Start()
    {
        audioDestroy = GetComponent<AudioSource>();
        exp = explosion;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(life);

        life -= 20;

        if(life <= 0)
        {
            audioDestroy.Play();

            Debug.Log("Hit Trigger!");


            exp =  Instantiate(explosion, transform.position, transform.rotation);
            exp.transform.position = this.transform.position;

            ScoreManager.score += Random.Range(1,200);

            Destroy(this.gameObject, lifetime);
            //Destroy(this.gameObject,audioDestroy.clip.length);
        }
    }
}
