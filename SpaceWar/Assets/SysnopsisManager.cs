using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SysnopsisManager : MonoBehaviour {

    public AudioClip clip;

    private void Start()
    {
        AudioManager.Instance().PlayClip(clip);
    }
}
