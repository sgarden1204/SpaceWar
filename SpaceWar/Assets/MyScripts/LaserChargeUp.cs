using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserChargeUp : MonoBehaviour
{
    public Slider lc;

    public float moveSpeed = 50.0f;
    public float rotateSpeed = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(lc.maxValue == lc.value)
            {
                ScoreManager.score += 1000;
            }

            else
            {
                lc.value += lc.maxValue;
            }

            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        this.transform.Translate(-(moveSpeed * Time.deltaTime), 0.0f, 0.0f);
        this.transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
    }
}
