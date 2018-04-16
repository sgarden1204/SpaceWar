using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour {

    public AudioClip clip;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().PlayOneShot(clip, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
