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

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        if(ScoreManager.Instance() != null)
        {
            ScoreManager.score = 0;
            PlayerPrefs.SetInt("Score", 0);
            ScoreManager.alive = false;
        }

        SceneManager.LoadScene("Sysnopsis");
    }

    public void StartModeGame()
    {
        SceneManager.LoadScene("InfiniteMode");
    }
}
