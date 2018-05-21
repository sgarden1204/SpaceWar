using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{

    public AudioClip clip;

    private void Start()
    {
        AudioManager.Instance().PlayClip(clip);
    }


}
