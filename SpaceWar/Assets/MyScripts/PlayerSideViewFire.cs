using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSideViewFire : MonoBehaviour {

    public GameObject laserBeam;
    public GameObject missile;
    public GameObject laser;

    public AudioClip laserSound;
    public AudioClip missileSound;
    public AudioClip laserBeamSound;

    public Transform shotSpawn;
    public float fireRate = 0.1f;

    public Slider lc;

    private float nextFire;
    private int changeWeapon = 0;
    private GameObject myLaser;
    private GameObject[] myMisile = new GameObject[4];
    private GameObject[] myLaserBeam = new GameObject[2];

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            changeWeapon++;

            if (changeWeapon == 3)
            {
                changeWeapon = 0;
            }
        }

        lc.value += 1;

        if (Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            switch (changeWeapon)
            {
                case 0:
                    lc.value += 20;
                    nextFire = Time.time + fireRate;
                    myMisile[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 3.0f);
                    myMisile[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 3.0f);
                    myMisile[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 3.0f);
                    myMisile[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[3].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y, shotSpawn.position.z + 3.0f);
                    GetComponent<AudioSource>().PlayOneShot(missileSound, 0.5f);
                    break;

                case 1:
                    if (lc.value > 100)
                    {
                        nextFire = Time.time + fireRate;
                        myLaser = Instantiate(laser, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaser.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 0.5f);
                        GetComponent<AudioSource>().PlayOneShot(laserSound, 0.5f);
                        lc.value -= 100;
                        Debug.Log(lc.value);
                    }
                    break;

                case 2:
                    nextFire = Time.time + fireRate;
                    myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myLaserBeam[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z+1.5f);
                    myLaserBeam[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myLaserBeam[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z+1.5f);
                    GetComponent<AudioSource>().PlayOneShot(laserBeamSound, 0.5f);
                    break;
            }
        }
    }
}
