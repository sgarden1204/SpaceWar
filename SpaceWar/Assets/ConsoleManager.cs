using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConsoleManager : MonoBehaviour {

    public static ConsoleManager consoleInstance = null;

    public static ConsoleManager Instance()
    {
        return consoleInstance;
    }

	// Use this for initialization
	void Start () {

        if (consoleInstance != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            consoleInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            Stage1Go();
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Stage2Go();
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Stage3Go();
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            Stage4Go();
        }
    }

    public void Stage1Go()
    {
        ScoreManager.score = 0;
        PlayerPrefs.SetInt("Score", 0);
        ScoreManager.alive = false;

        SceneManager.LoadScene("Stage1");
    }

    public void Stage2Go()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void Stage3Go()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void Stage4Go()
    {
        SceneManager.LoadScene("Stage4");
    }
}
