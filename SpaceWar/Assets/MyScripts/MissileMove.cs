using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour {

    public float moveSpeed = 15.0f;

    private void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
