using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit Trigger!");

        Destroy(this.gameObject);
    }
}
