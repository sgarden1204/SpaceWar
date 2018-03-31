using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{

    public AudioClip clip;

    private void Start()
    {
        AudioManager.Instance().PlayClip(clip);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Sysnopsis");
    }

    public void StartModeGame()
    {
        //SceneManager.LoadScene();
    }
}
