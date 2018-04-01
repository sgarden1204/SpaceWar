using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour {

    public float life = 100.0f;

    private AudioSource audioDestroy;

    private void Start()
    {
        audioDestroy = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(life);

        life -= 20.0f;

        if(life <= 0)
        {
            audioDestroy.Play();

            Debug.Log("Hit Trigger!");

            Destroy(this.gameObject,audioDestroy.clip.length);
        }
    }
}
