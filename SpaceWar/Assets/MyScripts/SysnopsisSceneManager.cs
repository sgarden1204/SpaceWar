using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SysnopsisSceneManager : MonoBehaviour {

    public AudioClip clip;

    private void Start()
    {
        AudioManager.Instance().PlayClip(clip);
    }

    public void SysnopsisSkip()
    {
        SceneManager.LoadScene("TutorialUI");
    }
}
