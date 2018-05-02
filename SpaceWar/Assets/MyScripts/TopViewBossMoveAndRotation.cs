using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopViewBossMoveAndRotation : MonoBehaviour {

    public float rotationSpeed = 1.0f;
    public float moveSpeed = 1.0f;

    float currentPos;

    bool leftmove = true;
    bool rightmove = false;

	// Use this for initialization
	void Start () {

        currentPos = this.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(0.0f,0.0f, 1.0f * rotationSpeed * Time.deltaTime);


        if (leftmove)
        {
            if (this.transform.position.x >= -20.0f)
            {
                this.transform.transform.position = new Vector3(currentPos, this.transform.position.y, this.transform.position.z);
                currentPos -= moveSpeed * Time.deltaTime;
            }

            else
            {
                leftmove = false;
                rightmove = true;
            }
        }

        if (rightmove)
        {
            if (this.transform.position.x <= 20.0f)
            {
                this.transform.transform.position = new Vector3(currentPos, this.transform.position.y, this.transform.position.z);
                currentPos += moveSpeed * Time.deltaTime;
            }

            else
            {
                leftmove = true;
                rightmove = false;
            }
        }
    }
}
