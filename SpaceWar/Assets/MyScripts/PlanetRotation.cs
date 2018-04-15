using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

    public float angle = 1.0f;

	// Update is called once per frame
	void FixedUpdate () {
        this.transform.Rotate(Vector3.up, angle);
	}
}
