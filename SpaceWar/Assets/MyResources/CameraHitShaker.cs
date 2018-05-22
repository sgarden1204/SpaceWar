using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHitShaker : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		

        if(Input.GetKeyUp(KeyCode.Alpha8))
        {
            EZCameraShake.CameraShaker.Instance.ShakeOnce(10.0f, 3.0f, 1.0f, 1.0f);
        }
	}
}
