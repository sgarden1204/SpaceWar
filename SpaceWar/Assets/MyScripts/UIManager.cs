using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    private bool optionActive = false;
    private bool startActive = false;

    public Transform optionPanel;
    public Transform missionPanel;

    public static Slider volumeSlider;

    private void Start()
    {

    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            ActiveOption();
        }
    }

    public void ActiveOption()
    {
        if (optionActive)
        {
            optionPanel.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
            optionActive = false;
        }

        else
        {
            optionPanel.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
            optionActive = true;
        }
    }

    public void ActiveMissionSlect()
    {
        if (startActive)
        {
            missionPanel.gameObject.SetActive(false);
            startActive = false;
        }

        else
        {
            missionPanel.gameObject.SetActive(true);
            startActive = true;
        }
    }

    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ChangeSlider()
    {
        volumeSlider = GameObject.Find("Volume Slider").GetComponent<Slider>();
        Volume.volumeOption = volumeSlider.value;
    }

    public void ReturnTitle()
    {
        SceneManager.LoadScene("Main");
    }

    public void StartStage1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void StartStage2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void StartStage3()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void StartStage4()
    {
        SceneManager.LoadScene("Stage4");
    }

    public void StartStage0()
    {
        if (ScoreManager.Instance() != null)
        {
            ScoreManager.score = 0;
            PlayerPrefs.SetInt("Score", 0);
            ScoreManager.alive = false;
        }

        SceneManager.LoadScene("Sysnopsis");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        if (startActive)
        {
            missionPanel.gameObject.SetActive(false);
            startActive = false;
        }

        else
        {
            missionPanel.gameObject.SetActive(true);
            startActive = true;
        }
    }

    public void StartModeGame()
    {
        SceneManager.LoadScene("InfiniteMode");
    }
}
