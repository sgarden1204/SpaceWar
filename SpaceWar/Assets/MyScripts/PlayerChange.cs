using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour {

    public GameObject [] Player = new GameObject[3];
    public static int changePlane = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Gear")
        {
            if(changePlane == 0 || changePlane == 1)
            {
                Player[changePlane].gameObject.SetActive(false);
                Player[changePlane + 1].gameObject.SetActive(true);
                changePlane++;
                Debug.Log("진화!" + changePlane);
            }
        }
    }
}
