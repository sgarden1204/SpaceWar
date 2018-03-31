using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {

    public Transform playerPos;

    private void Start()
    {
        this.transform.Rotate(15.0f, 0.0f, 0.0f);
    }

    void Update () {

        //this.transform.Translate(0.0f, 0.0f, 20.0f * Time.deltaTime);

        this.transform.position = new Vector3(playerPos.position.x, playerPos.position.y + 1.0f, playerPos.position.z - 1.0f);

        //this.transform.LookAt(playerPos);
    }
}
