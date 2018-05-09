using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewBossHit : MonoBehaviour {

    public Slider bossHp;
    public int damage = 10;
    public GameObject boom;
    public float boomPosValue = 20.0f;

    private GameObject[] boomPos = new GameObject[9];

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
                ScoreManager.Instance().ScoreSave();
                Explosion();
                Invoke("DelayNextScene", 3.0f);
            }
        }
    }

    public void DelayNextScene()
    {
        SceneManager.LoadScene("Stage4End");
    }

    public void Explosion()
    {
        boomPos[0] = Instantiate(boom);

        boomPos[1] = Instantiate(boom);
        boomPos[1].transform.position = new Vector3(this.transform.position.x + boomPosValue, this.transform.position.y, this.transform.position.z);

        boomPos[2] = Instantiate(boom);
        boomPos[2].transform.position = new Vector3(this.transform.position.x - boomPosValue , this.transform.position.y, this.transform.position.z);

        boomPos[3] = Instantiate(boom);
        boomPos[3].transform.position = new Vector3(this.transform.position.x + boomPosValue, this.transform.position.y + boomPosValue, this.transform.position.z);

        boomPos[4] = Instantiate(boom);
        boomPos[4].transform.position = new Vector3(this.transform.position.x, this.transform.position.y + boomPosValue, this.transform.position.z + boomPosValue);

        boomPos[5] = Instantiate(boom);
        boomPos[5].transform.position = new Vector3(this.transform.position.x, this.transform.position.y + boomPosValue, this.transform.position.z);

        boomPos[6] = Instantiate(boom);
        boomPos[6].transform.position = new Vector3(this.transform.position.x, this.transform.position.y - boomPosValue, this.transform.position.z);

        boomPos[7] = Instantiate(boom);
        boomPos[7].transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + boomPosValue);

        boomPos[8] = Instantiate(boom);
        boomPos[8].transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - boomPosValue);
    }

}
