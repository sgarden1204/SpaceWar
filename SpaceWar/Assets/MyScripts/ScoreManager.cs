using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager scoreInstance = null;

    public static int score;

    public Text scoretext;

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

        else
        {
            scoreInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
		
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha8))
        {
            score += 100;
        }
        scoretext.text = score.ToString("D8");
    }

    public void ScoreSave()
    {
        PlayerPrefs.SetInt("score", score);
    }

}
