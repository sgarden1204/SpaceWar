﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopViewBoss : MonoBehaviour {

    public Slider bossSlider;
    public Text score;

    public GameObject boom;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Missile")
        {
            bossSlider.value -= 1;
            ScoreManager.score += Random.Range(10, 10);
        }

        if(other.tag == "LaserBeam")
        {
            bossSlider.value -= 5;
            ScoreManager.score += Random.Range(10, 50);
        }

        if(other.tag == "Laser")
        {
            bossSlider.value -= 30;
            ScoreManager.score += Random.Range(10, 300);
        }

        if (other.tag == "SuperPlayerLaser")
        {
            bossSlider.value -= 100;
            ScoreManager.score += Random.Range(100, 1000);
        }

        if (bossSlider.value <= 0)
        {
            if (ScoreManager.Instance() != null)
            {
                ScoreManager.Instance().ScoreSave();
            }

            Instantiate(boom, this.transform);
            Invoke("DelayNextScene", 3.0f);
            Destroy(this.gameObject,3.0f);
        }


    }

    public void DelayNextScene()
    {
        SceneManager.LoadScene("Stage3Result");
    }
}
