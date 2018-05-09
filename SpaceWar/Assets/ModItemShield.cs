using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModItemShield : MonoBehaviour {

    public Slider shield;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (shield.value == shield.maxValue)
            {
                ModGameManager.modScore += 5000;
            }
            else
            {
                shield.value = shield.maxValue;
            }

            int posX = Random.Range(-46, 46);
            int posZ = Random.Range(-10, 36);

            this.transform.position = new Vector3(posX, 0.0f, posZ);
        }
    }
}
