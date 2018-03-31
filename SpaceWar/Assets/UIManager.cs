using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager uiInstatnce = null;

    private bool active = false;

    public Transform optionPanel;

    Slider volumeSlider;

    public static UIManager Instance()
    {
        return uiInstatnce;
    }

    private void Start()
    {
        if(uiInstatnce != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            uiInstatnce = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        
    }

    public void ActiveOption()
    {
        if (active)
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

    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ChangeSlider()
    {
        volumeSlider = GameObject.Find("Volume Slider").GetComponent<Slider>();
        Volume.volumeOption = volumeSlider.value;
    }
}
