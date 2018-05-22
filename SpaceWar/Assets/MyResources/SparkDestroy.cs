using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkDestroy : MonoBehaviour {

    public AudioClip explosion;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().PlayOneShot(explosion,0.2f);
        Destroy(this.gameObject, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
