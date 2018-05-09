using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{

    public float moveSpeed = 50.0f;
    public float rotateSpeed = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreManager.score += 20000;
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        this.transform.Translate(-(moveSpeed * Time.deltaTime), 0.0f, 0.0f);
        this.transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
    }
}
