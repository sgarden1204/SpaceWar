using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewSideBulletClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.UpArrow))
        {
            Destroy(this.gameObject);
        }

        if (Input.GetKey(KeyCode.X))
        {
            Destroy(this.gameObject);
        }
    }
}
