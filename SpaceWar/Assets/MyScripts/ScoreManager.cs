using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager scoreInstance = null;

    public static int score = 0;

    public static bool alive = false;

    //public Text scoretext;

    public static ScoreManager Instance()
    {
        return scoreInstance;
    }

	// Use this for initialization
	void Start () {
        
        if(scoreInstance != null)
        {
            Destroy(this.gameObject);
        }

        else // scoreInstace null;
        {
            scoreInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        //scoreInstance = this;
        //DontDestroyOnLoad(this.gameObject);
		
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            score += 100;
        }
        //scoretext.text = score.ToString("D8");
    }

    public void ScoreSave()
    {
        int highScore;
        int currentScore;

        highScore = PlayerPrefs.GetInt("HighScore");
        currentScore = score; //PlayerPrefs.GetInt("Score") + score;

        if(highScore <= currentScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        PlayerPrefs.SetInt("Score", currentScore);
    }
}
