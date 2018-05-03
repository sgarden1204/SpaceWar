using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewLookAtPlayer : MonoBehaviour {

    public Transform playerPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(-playerPos.transform.position);
        //this.transform.LookAt(playerPos);

    }
}
