using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour {

    public Text missionResultText;
    public Text scoreResultText;
    public Text highScoreResultText;
    public Text rankResultText;

    public AudioClip clip;

    // Use this for initialization
    void Start () {

        Invoke("ResultMission", 2.0f);
        Invoke("ResultYourScore", 3.0f);
        Invoke("ResultYourRank", 4.0f);
        Invoke("ResultHighScore", 5.0f);

        if (AudioManager.Instance() != null)
        {
            AudioManager.Instance().PlayClip(clip);
        }

        else
            GetComponent<AudioSource>().PlayOneShot(clip, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResultMission()
    {
        if(ScoreManager.alive)
        {
            missionResultText.text = "SUCCESS";
        }

        else
        {
            missionResultText.text = "FAIL";
        }

    }

    public void ResultYourScore()
    {
        scoreResultText.text = ScoreManager.score.ToString("D8");
    }

    public void ResultYourRank()
    {
        rankResultText.text = "A";

        // switch() 로 점수에 따른 랭크 구분
    }

    public void ResultHighScore()
    {
        //if 000100000 10만점
        int highScore;
        int currentScore;

        currentScore = PlayerPrefs.GetInt("Score");
        highScore = PlayerPrefs.GetInt("HighScore");

        if(highScore == 0)
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }

        highScoreResultText.text = PlayerPrefs.GetInt("HighScore").ToString("D8");
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene("Main");
    }
}
