using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    private bool active = false;

    public Transform optionPanel;

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
        if (active)
        {
            optionPanel.gameObject.SetActive(false);
            Time.timeScale = 1.0f;
            active = false;
        }

        else
        {
            optionPanel.gameObject.SetActive(true);
            Time.timeScale = 0.0f;
            active = true;
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
}
