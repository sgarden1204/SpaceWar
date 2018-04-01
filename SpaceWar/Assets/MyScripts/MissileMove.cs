using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour {

    public float moveSpeed = 1000.0f;

    private void Start()
    {

    }

    private void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
