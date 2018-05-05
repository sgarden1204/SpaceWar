using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalViewPlayerFireSide : MonoBehaviour
{
    public float testX = 1.0f;
    public float testY = 10.0f;
    public float testZ = 10.0f;

    public int powerUpCount = 3;

    public GameObject laserBeam;
    public GameObject missile;

    public GameObject laserV1;
    public GameObject laserV2;
    public GameObject laserV3;
    public GameObject laserV4;

    public AudioClip laserSound;
    public AudioClip missileSound;
    public AudioClip laserBeamSound;

    public Transform shotSpawn;
    public float fireRate = 0.1f;

    public Slider lc;

    private float nextFire;
    private int changeWeapon = 0;

    private GameObject myLaser1;
    private GameObject myLaser2;
    private GameObject myLaserLeftV3;
    private GameObject myLaserRightV3;

    private GameObject[] myMisile = new GameObject[4];

    private GameObject[] myMisileVersion2Left = new GameObject[4];
    private GameObject[] myMisileVersion2Right = new GameObject[4];

    private GameObject[] myMisileVersion3Left = new GameObject[4];
    private GameObject[] myMisileVersion3Right = new GameObject[4];

    private GameObject[] myLaserBeam = new GameObject[2];

    private GameObject[] myLaserBeamVersion2Left = new GameObject[2];
    private GameObject[] myLaserBeamVersion2Right = new GameObject[2];
    private GameObject[] myLaserBeamVersion2MidLeft = new GameObject[2];
    private GameObject[] myLaserBeamVersion2MidRight = new GameObject[2];

    private GameObject[] myLaserBeamVersion3Left = new GameObject[2];
    private GameObject[] myLaserBeamVersion3Right = new GameObject[2];
    private GameObject[] myLaserBeamVersion3MidLeft = new GameObject[2];
    private GameObject[] myLaserBeamVersion3MidRight = new GameObject[2];


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


        if (powerUpCount == 1)
            fireRate = 0.2f;

        lc.value++;
        if (Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            switch (changeWeapon)
            {
                case 0:
                    lc.value += 20;
                    nextFire = Time.time + fireRate;

                    myMisile[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[0].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y, shotSpawn.position.z - 3.0f);
                    myMisile[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 3.0f);
                    myMisile[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 3.0f);
                    myMisile[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                    myMisile[3].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 3.0f);

                    if (powerUpCount >= 2)
                    {
                        myMisileVersion2Left[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Left[0].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y - testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Left[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Left[1].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y - testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Left[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Left[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Left[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Left[3].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y - testX, shotSpawn.position.z - 2.0f);

                        myMisileVersion2Right[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Right[0].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y + testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Right[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Right[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Right[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Right[2].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y + testX, shotSpawn.position.z - 2.0f);
                        myMisileVersion2Right[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion2Right[3].transform.position = new Vector3(shotSpawn.position.x , shotSpawn.position.y + testX, shotSpawn.position.z - 2.0f);
                    }

                    if (powerUpCount >= 3)
                    {
                        myMisileVersion3Left[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Left[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Left[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Left[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Left[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Left[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Left[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Left[3].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - testX * 2, shotSpawn.position.z - 1.0f);

                        myMisileVersion3Right[0] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Right[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Right[1] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Right[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Right[2] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Right[2].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + testX * 2, shotSpawn.position.z - 1.0f);
                        myMisileVersion3Right[3] = Instantiate(missile, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myMisileVersion3Right[3].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + testX * 2, shotSpawn.position.z - 1.0f);

                    }



                    GetComponent<AudioSource>().PlayOneShot(missileSound, 0.5f);
                    break;

                case 1:
                    if (lc.value > 100)
                    {
                        nextFire = Time.time + fireRate;

                        if (powerUpCount == 1)
                        {
                            myLaser1 = Instantiate(laserV1, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                            myLaser1.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 0.5f);
                        }

                        if (powerUpCount == 2)
                        {
                            myLaser2 = Instantiate(laserV2, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                            myLaser2.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z + 0.5f);
                        }

                        if (powerUpCount >= 3)
                        {
                            myLaserLeftV3 = Instantiate(laserV3, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                            myLaserLeftV3.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 5.0f);

                            myLaserRightV3 = Instantiate(laserV4, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                            myLaserRightV3.transform.position = new Vector3(shotSpawn.position.x - 1.0f, shotSpawn.position.y, shotSpawn.position.z - 5.0f);
                        }


                        GetComponent<AudioSource>().PlayOneShot(laserSound, 0.5f);
                        lc.value -= 100;
                    }
                    break;

                case 2:
                    nextFire = Time.time + fireRate;

                    if (powerUpCount <= 1 || powerUpCount >= 3)
                    {
                        myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeam[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeam[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeam[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                    }

                    if (powerUpCount == 2)
                    {
                        myLaserBeamVersion2MidLeft[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2MidLeft[0].transform.position = new Vector3(shotSpawn.position.x - 0.5f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2MidLeft[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2MidLeft[1].transform.position = new Vector3(shotSpawn.position.x - 0.5f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);

                        myLaserBeamVersion2MidRight[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2MidRight[0].transform.position = new Vector3(shotSpawn.position.x + 0.5f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2MidRight[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2MidRight[1].transform.position = new Vector3(shotSpawn.position.x + 0.5f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);

                        myLaserBeamVersion2Left[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Left[0].transform.position = new Vector3(shotSpawn.position.x - 2.0f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2Left[0].transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                        myLaserBeamVersion2Left[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Left[1].transform.position = new Vector3(shotSpawn.position.x - 2.0f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2Left[1].transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

                        myLaserBeamVersion2Right[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Right[0].transform.position = new Vector3(shotSpawn.position.x + 2.0f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2Right[0].transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                        myLaserBeamVersion2Right[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Right[1].transform.position = new Vector3(shotSpawn.position.x + 2.0f, shotSpawn.position.y, shotSpawn.position.z - 1.5f);
                        myLaserBeamVersion2Right[1].transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                    }

                    if (powerUpCount >= 3)
                    {

                        myLaserBeamVersion2Left[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Left[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 1.0f, shotSpawn.position.z - 1.0f);
                        myLaserBeamVersion2Left[0].transform.eulerAngles = new Vector3(195.0f, 0.0f, 0.0f);
                        myLaserBeamVersion2Left[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Left[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 1.0f, shotSpawn.position.z - 1.0f);
                        myLaserBeamVersion2Left[1].transform.eulerAngles = new Vector3(195.0f, 0.0f, 0.0f);

                        myLaserBeamVersion2Right[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Right[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 1.0f, shotSpawn.position.z - 1.0f);
                        myLaserBeamVersion2Right[0].transform.eulerAngles = new Vector3(-195.0f, 0.0f, 0.0f);
                        myLaserBeamVersion2Right[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion2Right[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 1.0f, shotSpawn.position.z - 1.0f);
                        myLaserBeamVersion2Right[1].transform.eulerAngles = new Vector3(-195.0f, 0.0f, 0.0f);

                        ////////////////////////////////////////////////////////////////////////////

                        myLaserBeamVersion3MidLeft[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3MidLeft[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3MidLeft[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3MidLeft[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 2.0f, shotSpawn.position.z + 1.5f);

                        myLaserBeamVersion3MidRight[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3MidRight[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3MidRight[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3MidRight[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 2.0f, shotSpawn.position.z + 1.5f);

                        myLaserBeamVersion3Left[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3Left[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3Left[0].transform.eulerAngles = new Vector3(-210.0f, 0.0f, 0.0f);
                        myLaserBeamVersion3Left[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3Left[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y - 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3Left[1].transform.eulerAngles = new Vector3(-210.0f, 0.0f, 0.0f);

                        myLaserBeamVersion3Right[0] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3Right[0].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3Right[0].transform.eulerAngles = new Vector3(210.0f, 0.0f, 0.0f);
                        myLaserBeamVersion3Right[1] = Instantiate(laserBeam, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
                        myLaserBeamVersion3Right[1].transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y + 2.0f, shotSpawn.position.z + 1.5f);
                        myLaserBeamVersion3Right[1].transform.eulerAngles = new Vector3(210.0f, 0.0f, 0.0f);
                    }


                    GetComponent<AudioSource>().PlayOneShot(laserBeamSound, 0.5f);
                    break;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ItemPowerUp")
        {
            powerUpCount++;
        }
    }
}
