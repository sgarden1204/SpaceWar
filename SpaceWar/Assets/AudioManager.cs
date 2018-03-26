using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    static AudioManager audioInstance = null;

    public static AudioManager Instance()
    {
        return audioInstance;
    }

    private void Start()
    {
        if(audioInstance == null)
        {
            audioInstance = this;
        }
    }

    public void PlayClip(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public void StopClip(AudioClip clip)
    {
        GetComponent<AudioSource>().Stop();
    }
}
