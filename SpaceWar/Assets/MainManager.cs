using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor.UI;

public class MainManager : MonoBehaviour {

    public AudioClip clip;

    public Transform optionPanel;

    private bool active = false;

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
        //Application.LoadLevel(1);
    }

    public void StartModeGame()
    {
        //SceneManager.LoadScene();
    }

    public void ActiveOption()
    {
        if(active)
        {
            optionPanel.gameObject.SetActive(false);
            active = false;
        }

        else
        {
            optionPanel.gameObject.SetActive(true);
            active = true;
        }
    }
}
