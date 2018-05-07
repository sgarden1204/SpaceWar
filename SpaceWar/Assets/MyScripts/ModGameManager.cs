using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModGameManager : MonoBehaviour {

    public Transform gameStart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        gameStart.gameObject.SetActive(false);
    }
}
