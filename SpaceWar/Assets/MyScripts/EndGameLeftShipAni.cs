using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameLeftShipAni : MonoBehaviour {

    public float moveSpeed = 1.0f;

    public GameObject Laser;

    public float Lpos = 5.0f;

    public Transform text;

    private bool one = true;
    private GameObject LaserPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z < 10)
        {
            this.transform.position = new Vector3(this.transform.position.x + moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z + moveSpeed * Time.deltaTime);
        }

        else if(one)
        {
            LaserPos = Instantiate(Laser, this.transform.position, this.transform.rotation);
            LaserPos.transform.position = new Vector3(this.transform.position.x + Lpos, this.transform.position.y, this.transform.position.z + Lpos);
            LaserPos.transform.eulerAngles = new Vector3(0.0f, -45.0f, 0.0f);
            text.gameObject.SetActive(true);
            Invoke("NextScene", 3.5f);
            one = false;
        }
	}

    public void NextScene()
    {
        ScoreManager.alive = true;
        SceneManager.LoadScene("Result");
    }
}
