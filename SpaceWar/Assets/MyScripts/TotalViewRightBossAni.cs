using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewRightBossAni : MonoBehaviour {

    public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x >= 10)
        {
            this.transform.position = new Vector3(this.transform.position.x - moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
	}
}
