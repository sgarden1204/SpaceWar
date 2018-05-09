using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModItemPowerUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ModeGamePlayerFire.powerUpCount++;

            if(ModeGamePlayerFire.powerUpCount >= 3)
            {
                ModGameManager.modScore += 1000;
            }

            int posX = Random.Range(-46,46);
            int posZ = Random.Range(-10,36);

            this.transform.position = new Vector3(posX, 0.0f, posZ);
        }
    }
}
