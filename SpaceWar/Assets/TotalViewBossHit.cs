using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewBossHit : MonoBehaviour {

    public Slider bossHp;
    public int damage = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerMissile" || other.tag == "Missile" || other.tag == "LaserBeam")
        {
            bossHp.value -= damage;

            if (ScoreManager.Instance() != null)
            {
                ScoreManager.score += Random.Range(1000, 5000);
            }

            if(bossHp.value <= 0)
            {
                SceneManager.LoadScene("Stage4End");
            }
        }
    }
}
