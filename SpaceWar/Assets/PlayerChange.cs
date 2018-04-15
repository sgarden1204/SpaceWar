using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour {

    public GameObject [] Player = new GameObject[3];
    private int changePlane = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            Player[changePlane].gameObject.SetActive(false);
            Player[changePlane+1].gameObject.SetActive(true);
            changePlane++;
        }
	}
}
