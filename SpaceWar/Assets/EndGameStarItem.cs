using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameStarItem : MonoBehaviour {

    public GameObject leftShip;
    public GameObject rightShip;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        leftShip.SetActive(true);
        rightShip.SetActive(true);
        Destroy(this.gameObject);
    }
}
