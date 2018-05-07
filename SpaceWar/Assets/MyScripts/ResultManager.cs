using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour {

    public AudioClip clip;

    // Use this for initialization
    void Start () {

        //AudioManager.Instance().PlayClip(clip);

        //if(AudioManager.Instance() == null)
        //{

        //}
        GetComponent<AudioSource>().PlayOneShot(clip, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
