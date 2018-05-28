using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBulletClear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.UpArrow))
        {
            Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.LeftArrow))
        {
            Destroy(this.gameObject);
            this.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.X))
        {
            this.gameObject.SetActive(true);
        }

    }
}
