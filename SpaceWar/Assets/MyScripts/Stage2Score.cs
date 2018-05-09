using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stage2Score : MonoBehaviour {

    public Text myScore; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myScore.text = ScoreManager.score.ToString("D8");
	}
}
