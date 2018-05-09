using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModGameManager : MonoBehaviour {

    public Transform gameStart;

    public static int modScore = 0;

    public Text scoreText;

    private bool escape = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = modScore.ToString("D8");

        if(Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }

        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            if(escape)
            {
                Time.timeScale = 0.0f;
                escape = false;
            }

            else
            {
                Time.timeScale = 1.0f;
                escape = true;
            }
        }
	}

    public void GameStart()
    {
        gameStart.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
