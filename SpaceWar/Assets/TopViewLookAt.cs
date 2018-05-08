using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewLookAt : MonoBehaviour {

    GameObject playerPos;

	// Use this for initialization
	void Start () {
        playerPos = GameObject.Find("PlayerPos");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(playerPos.transform);
	}
}
