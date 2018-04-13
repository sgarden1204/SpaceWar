using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBoom : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
