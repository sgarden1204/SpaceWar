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

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("트리거 충돌!");
    //    //Destroy(this.gameObject);
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("콜리전 충돌!");
    //    Destroy(this.gameObject);
    //}
}
