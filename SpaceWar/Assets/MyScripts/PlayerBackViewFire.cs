using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBackViewFire : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate = 0.1f;

    private float nextFire;
    private GameObject go;

    private void Update()
    {
        if(Input.GetKey(KeyCode.Z) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            go = Instantiate(shot, shotSpawn.position * Time.deltaTime, shotSpawn.rotation);
            go.transform.position = new Vector3(shotSpawn.position.x, shotSpawn.position.y +0.1f, shotSpawn.position.z + 30.0f);
            GetComponent<AudioSource>().Play();
        }
    }
}
