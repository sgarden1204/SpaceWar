using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewAutoExplosion : MonoBehaviour {

    public GameObject explosion;

	// Use this for initialization
	void Start () {
        float randomValue = Random.Range(0.0f, 5.0f);
        InvokeRepeating("AutoExplosion", randomValue, randomValue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AutoExplosion()
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
