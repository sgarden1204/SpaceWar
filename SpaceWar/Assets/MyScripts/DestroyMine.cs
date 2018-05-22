using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMine : MonoBehaviour
{

    public float life = 100.0f;

    public GameObject explosion;
    //public AudioClip explosionClip;

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

        if(other.tag == "Player")
        {
            //GetComponent<AudioSource>().PlayOneShot(explosionClip);
            //audioDestroy.PlayOneShot(explosionClip);

            //audioDestroy.Play();
            //GetComponent<AudioSource>().Play();
            exp = Instantiate(explosion, transform.position, transform.rotation);

            Debug.Log("Hit Trigger!");


            //exp.transform.position = this.transform.position;

            ScoreManager.score += Random.Range(1, 200);

            //Destroy(this.gameObject, lifetime);
            Destroy(this.gameObject);
        }

        if (other.tag == "PlayerMissile")
        {
            life -= 20;

            if (life <= 0)
            {
                //audioDestroy.Play();
                exp = Instantiate(explosion, transform.position, transform.rotation);

                Debug.Log("Hit Trigger!");


                //exp.transform.position = this.transform.position;

                ScoreManager.score += Random.Range(1, 200);

                Destroy(this.gameObject);
                //Destroy(this.gameObject, lifetime);
                //Destroy(this.gameObject,audioDestroy.clip.length);
            }
        }
    }
}
