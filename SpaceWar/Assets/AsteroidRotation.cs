using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour {

    public float angle = 1.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(1.0f,angle,1.0f);
    }
}
