using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSceneManager : MonoBehaviour {

    public AudioClip clip;

	// Use this for initialization
	void Start () {
        AudioManager.Instance().PlayClip(clip);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
