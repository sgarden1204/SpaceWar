using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    static AudioManager audioInstance = null;

    public float setVolume = 0.5f;

    public static AudioManager Instance()
    {
        return audioInstance;
    }

    private void Start()
    {
        if (audioInstance == null)
        {
            audioInstance = this;
        }
    }

    public void PlayClip(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip, setVolume);
    }

    public void StopClip(AudioClip clip)
    {
        GetComponent<AudioSource>().Stop();
    }
}
