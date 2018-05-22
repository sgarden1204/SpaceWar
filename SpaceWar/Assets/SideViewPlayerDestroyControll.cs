﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideViewPlayerDestroyControll : MonoBehaviour {

    private GameObject playerPos;

	// Use this for initialization
	void Start () {
        playerPos = GameObject.Find("PlayerPos");
        Destroy(this.gameObject, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = playerPos.transform.position;
	}
}
