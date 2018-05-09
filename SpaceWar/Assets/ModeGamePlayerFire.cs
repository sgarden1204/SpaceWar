using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeGamePlayerFire : MonoBehaviour {

    public static int powerUpCount = 0;

    public AudioClip laserBeamSound;

    public Transform shotSpawn;
    public float fireRate = 0.3f;
    public GameObject laserBeam;

    private bool shotX = false;
    private float nextFire;
    private GameObject[] myLaserBeam = new GameObject[8];
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyUp(KeyCode.Alpha0))
        {
            powerUpCount++;
        }

        if (Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            switch(powerUpCount)
            {
                case 0:
                    myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    break;

                case 1:
                    myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[1] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[1].transform.Rotate(0.0f, 180.0f, 0.0f);
                    //myLaserBeam[1].transform.position = new Vector3(shotSpawn.position.x, -shotSpawn.position.y, shotSpawn.position.z);
                    //myLaserBeam[1].transform.eulerAngles = new Vector3(shotSpawn.rotation.x, shotSpawn.rotation.y, shotSpawn.rotation.z + 180.0f);
                    //myLaserBeam[1].transform.eulerAngles = new Vector3(0.0f, shotSpawn.rotation.y + 180.0f,0.0f);
                    break;

                case 2:
                    myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[1] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[1].transform.Rotate(0.0f, 180.0f, 0.0f);
                    myLaserBeam[2] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[2].transform.Rotate(0.0f, 90.0f, 0.0f);
                    myLaserBeam[3] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                    myLaserBeam[3].transform.Rotate(0.0f, 270.0f, 0.0f);
                    break;

                default:
                    fireRate = 0.15f;

                    if (shotX)
                    {
                        myLaserBeam[4] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[4].transform.Rotate(0.0f, 45.0f, 0.0f);
                        myLaserBeam[5] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[5].transform.Rotate(0.0f, 135.0f, 0.0f);
                        myLaserBeam[6] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[6].transform.Rotate(0.0f, 225.0f, 0.0f);
                        myLaserBeam[7] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[7].transform.Rotate(0.0f, 315.0f, 0.0f);
                        shotX = false;
                    }
                    else
                    {
                        myLaserBeam[0] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[1] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[1].transform.Rotate(0.0f, 180.0f, 0.0f);
                        myLaserBeam[2] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[2].transform.Rotate(0.0f, 90.0f, 0.0f);
                        myLaserBeam[3] = Instantiate(laserBeam, shotSpawn.position, shotSpawn.rotation);
                        myLaserBeam[3].transform.Rotate(0.0f, 270.0f, 0.0f);
                        shotX = true;
                    }
                    break;
            }
            GetComponent<AudioSource>().PlayOneShot(laserBeamSound, 0.5f);
        }

    }
}
