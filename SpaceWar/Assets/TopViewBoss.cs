using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopViewBoss : MonoBehaviour {

    public Slider bossSlider;
    public Text score;

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
            TopViewScoreManager.score += Random.Range(10, 10);
        }

        if(other.tag == "LaserBeam")
        {
            bossSlider.value -= 5;
            TopViewScoreManager.score += Random.Range(10, 50);
        }

        if(other.tag == "Laser")
        {
            bossSlider.value -= 30;
            TopViewScoreManager.score += Random.Range(10, 300);
        }



        if(bossSlider.value <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
