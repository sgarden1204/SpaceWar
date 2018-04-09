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
    private GameObject myLaser;
    private GameObject [] myMisile = new GameObject[4];
    private GameObject[] myLaserBeam = new GameObject[2];


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
                    myMisile[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[0].transform.position = new Vector3(shotSpawn.position.x- 25.0f, shotSpawn.position.y +1.0f, shotSpawn.position.z + 200.0f);
                    myMisile[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[1].transform.position = new Vector3(shotSpawn.position.x + 25.0f, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 200.0f);
                    myMisile[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[2].transform.position = new Vector3(shotSpawn.position.x - 25.0f, shotSpawn.position.y - 40.0f, shotSpawn.position.z + 200.0f);
                    myMisile[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[3].transform.position = new Vector3(shotSpawn.position.x + 25.0f, shotSpawn.position.y - 40.0f, shotSpawn.position.z + 200.0f);
                    GetComponent<AudioSource>().PlayOneShot(missileSound, 0.5f);
                    break;

                case 1:
                    nextFire = Time.time + fireRate;
                    myLaser = Instantiate(laser, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myLaser.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 50.0f);
                    GetComponent<AudioSource>().PlayOneShot(laserSound, 0.5f);
                    break;

                case 2:
                    nextFire = Time.time + fireRate;
                    myLaserBeam[0] = Instantiate(machinegun, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myLaserBeam[0].transform.position = new Vector3(shotSpawn.position.x + 550.0f, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 500.0f);
                    myLaserBeam[1] = Instantiate(machinegun, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myLaserBeam[1].transform.position = new Vector3(shotSpawn.position.x - 550.0f, shotSpawn.position.y + 1.0f, shotSpawn.position.z + 500.0f);
                    GetComponent<AudioSource>().PlayOneShot(machinegunSound, 0.5f);
                    break;
            }
        }
    }
}
