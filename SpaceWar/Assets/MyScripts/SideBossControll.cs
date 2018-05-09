using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SideBossControll : MonoBehaviour {

    public GameObject enemyMissile;
    public AudioClip missileSound;

    private GameObject playerPos;
    public GameObject boss;
    private Slider bossHp;

    public float distance = 10.0f;

    private bool upAndDown = true;
    private float maxUpDown = 0.0f;
    private int delayFrame = 0;
    private float upDown = 0.0f;

    private GameObject fire;
    public GameObject boom;

	// Use this for initialization
	void Start () {

        playerPos = GameObject.Find("PlayerPos");
        boss = GameObject.Find("BossHP");
        bossHp = boss.GetComponent<Slider>();
        //boom = GameObject.Find("SideBossExplosion");
        Debug.Log(playerPos);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        this.transform.position = new Vector3(0.0f, upDown, playerPos.transform.position.z + distance);
        if (delayFrame >= 20)
        {
            upDown = Random.Range(-10.0f, 10.0f);
            this.transform.position = new Vector3(0.0f, upDown, playerPos.transform.position.z + distance);
            fire = Instantiate(enemyMissile, this.transform.position, this.transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(missileSound, 0.5f);

            delayFrame = 0;
        }
        delayFrame++;
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerMissile" || other.tag == "Player")
        {
            
            bossHp.value -= 10.0f;
        }

        if(bossHp.value <= 0)
        {
            Invoke("DelayNextScene",2.0f);
            Destroy(this.gameObject, 2.0f);


            if(ScoreManager.Instance() != null)
            {
                ScoreManager.Instance().ScoreSave();
            }
        }
    }

    public void DelayNextScene()
    {
        SceneManager.LoadScene("Stage3");
    }
}
