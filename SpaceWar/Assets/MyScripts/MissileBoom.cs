using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBoom : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 작동?!");
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("콜리전 작동:!");
    }
}
