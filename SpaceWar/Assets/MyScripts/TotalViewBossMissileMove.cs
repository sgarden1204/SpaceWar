using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossMissileMove : MonoBehaviour
{

    public float moveSpeed = 50.0f;

    private void Start()
    {

    }

    private void Update()
    {
        transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }
}
