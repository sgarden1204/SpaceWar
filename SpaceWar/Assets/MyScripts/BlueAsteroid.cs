using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlueAsteroid : MonoBehaviour
{

    public Transform button;

    public Text goal;
    public Text uiux;

    public float life = 100.0f;

    public GameObject explosion;

    private AudioSource audioDestroy;
    private GameObject exp;


    public float lifetime = 1.5f;

    private void Start()
    {
        audioDestroy = GetComponent<AudioSource>();
        exp = explosion;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TestBeam")
        {
            Debug.Log("Testbeam?");
            life -= 20;

            if (life <= 0)
            {
                audioDestroy.Play();

                Debug.Log("Hit Trigger!");


                exp = Instantiate(explosion, transform.position, transform.rotation);
                exp.transform.position = this.transform.position;

                ScoreManager.score += Random.Range(1, 200);

                GoalCount();
                goal.text = TutorialSceneManager.goalCount.ToString();
                uiux.gameObject.SetActive(false);
                Destroy(this.gameObject, lifetime);
                //Destroy(this.gameObject,audioDestroy.clip.length);
            }
        }

        //if (other.tag == "PlayerMissile")
        //{

        //}
    }

    private void GoalCount()
    {
        switch (TutorialSceneManager.goalCount)
        {
            case 0:
                TutorialSceneManager.goalCount = 1;
                break;

            case 1:
                TutorialSceneManager.goalCount = 2;
                break;

            case 2:
                TutorialSceneManager.goalCount = 3;

                button.gameObject.SetActive(true);
                break;
        }
        button.gameObject.SetActive(true);
        Debug.Log(TutorialSceneManager.goalCount);
    }
}
