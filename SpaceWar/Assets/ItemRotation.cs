using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour {

    public float itemrotation = 1.0f;
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(Vector3.up * itemrotation * Time.deltaTime);

	}
}
