using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObjectMove : MonoBehaviour {

    public float moveSpeed = 5.0f;
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0.0f, 0.0f, -(moveSpeed * Time.deltaTime));
	}
}
