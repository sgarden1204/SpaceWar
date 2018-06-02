using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerPos")
        {
            ScoreManager.Instance().ScoreSave();
            NextScene();
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Stage1Result");
    }
}
