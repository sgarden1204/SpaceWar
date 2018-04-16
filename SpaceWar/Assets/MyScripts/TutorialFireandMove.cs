using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialFireandMove : MonoBehaviour
{
    public GameObject redAsteroid;
    public GameObject blueAsteroid;
    public GameObject rockAsteroid;

    public Text[] goal = new Text[3];

    public Text[] uiux = new Text[3];


    public Text[] text = new Text[15];

    private int next = 0;

    public Image image;
    public Sprite sprite;
    public Transform panel;

    void Start()
    {
        InvokeRepeating("StartText", 2.5f, 2.5f);
    }

    void Update()
    {

    }

    void StartText()
    {
        text[next].gameObject.SetActive(false);
        next++;
        text[next].gameObject.SetActive(true);

        switch (next)
        {
            case 6:
                redAsteroid.gameObject.SetActive(true);
                blueAsteroid.gameObject.SetActive(true);
                rockAsteroid.gameObject.SetActive(true);

                break;

            case 7:
                goal[0].gameObject.SetActive(true);
                goal[1].gameObject.SetActive(true);
                goal[2].gameObject.SetActive(true);
                break;

            case 12:
                uiux[0].gameObject.SetActive(true);
                uiux[1].gameObject.SetActive(true);
                uiux[2].gameObject.SetActive(true);

                break;

            case 15:
                panel.gameObject.SetActive(false);
                CancelInvoke();
                break;
            default:
                break;
        }
    }
}
