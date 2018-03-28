using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager audioInstance = null;

    public float setVolume = 0.5f;

    public static AudioManager Instance()
    { 
        return audioInstance;
    }

    private void Start()
    {
        if (audioInstance != null)
        {
            Destroy(this.gameObject);
        }
        
        else
        {
            audioInstance = this;
            DontDestroyOnLoad(this.gameObject);
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
