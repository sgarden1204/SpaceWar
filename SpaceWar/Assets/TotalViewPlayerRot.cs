using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewPlayerRot : MonoBehaviour {

    public float rot = 45.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.Space))
        {
            this.transform.eulerAngles = new Vector3(0.0f, 180.0f - rot * Time.deltaTime, 0.0f);
        }
    }
}
