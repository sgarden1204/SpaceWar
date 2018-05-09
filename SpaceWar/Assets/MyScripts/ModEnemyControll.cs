using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModEnemyControll : MonoBehaviour {

    public int life = 1;
    public float moveSpeed = 1;

    public AudioClip clip;

    GameObject playerPos;
	// Use this for initialization
	void Start () {
        playerPos = GameObject.Find("PlayerPos");
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.LookAt(playerPos.transform);

        this.transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            int posX = Random.Range(-46, 46);
            int posZ = Random.Range(-10, 36);

            this.transform.position = new Vector3(posX, 0.0f, posZ);
            GetComponent<AudioSource>().PlayOneShot(clip, 0.1f);
        }

        if(other.tag == "PlayerMissile")
        {
            life--;

            if(life <= 0)
            {
                int posX = Random.Range(-46, 46);
                int posZ = Random.Range(-10, 36);

                this.transform.position = new Vector3(posX, 0.0f, posZ);
                GetComponent<AudioSource>().PlayOneShot(clip, 0.1f);

                ModGameManager.modScore += Random.Range(500, 1000);
            }
        }
    }
}
