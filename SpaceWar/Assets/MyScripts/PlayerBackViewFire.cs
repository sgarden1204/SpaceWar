using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBackViewFire : MonoBehaviour {

    public GameObject machinegun;
    public GameObject missile;
    public GameObject laser;

    public AudioClip laserSound;
    public AudioClip missileSound;
    public AudioClip machinegunSound;

    public Transform shotSpawn;
    public float fireRate = 0.1f;

    private float nextFire;
    private int changeWeapon = 0;
    private GameObject go;
    private GameObject [] misile = new GameObject[4];


    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            changeWeapon++;

            if(changeWeapon == 3)
            {
                changeWeapon = 0;
            }
        }

        if(Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            switch(changeWeapon)
            {
                case 0:
                    nextFire = Time.time + fireRate;
                    misile[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    misile[0].transform.position = new Vector3(shotSpawn.position.x- 25.0f, shotSpawn.position.y +1.0f, shotSpawn.position.z + 200.0f);
                    misile[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    misile[1].transform.position = new Vector3(shotSpawn.position.x + 25.0f, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 200.0f);
                    misile[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    misile[2].transform.position = new Vector3(shotSpawn.position.x - 25.0f, shotSpawn.position.y - 40.0f, shotSpawn.position.z + 200.0f);
                    misile[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    misile[3].transform.position = new Vector3(shotSpawn.position.x + 25.0f, shotSpawn.position.y - 40.0f, shotSpawn.position.z + 200.0f);
                    GetComponent<AudioSource>().PlayOneShot(missileSound, 0.5f);
                    break;

                case 1:
                    nextFire = Time.time + fireRate;
                    go = Instantiate(laser, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    go.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 50.0f);
                    GetComponent<AudioSource>().PlayOneShot(laserSound, 0.5f);
                    break;

                case 2:
                    nextFire = Time.time + fireRate;
                    go = Instantiate(machinegun, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    go.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 100.0f);
                    GetComponent<AudioSource>().PlayOneShot(machinegunSound, 0.5f);
                    break;
            }
        }
    }
}
