using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopViewScoreManager : MonoBehaviour {

    public Text scoreText;
    //public static int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreManager.Instance() != null)
        {
            scoreText.text = ScoreManager.score.ToString("D8");
        }
	}
}
