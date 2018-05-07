using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUIText : MonoBehaviour {

    public Slider lc;
    public Slider shield;
    public Button pause;
    public Transform pausePanel;
    public Text score;
    public Text scoreText;
    public Image bullet;
    public Image scope;
    public Image crosshair;
    public Image change;


    public Text[] text = new Text[15];

    private int next = 0;

    public Image image;
    public Sprite sprite;
    public Transform panel;

	void Start () {
        InvokeRepeating("StartText", 2.5f, 2.5f);
    }
	
	void Update () {
		
	}

    void StartText()
    {
        text[next].gameObject.SetActive(false);
        next++;
        text[next].gameObject.SetActive(true);

        switch (next)
        {
            case 3:
                pause.gameObject.SetActive(true);
                //pausePanel.gameObject.SetActive(true);
                break;
            case 4:
                pause.gameObject.SetActive(false);
                //pausePanel.gameObject.SetActive(false);

                score.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(true);
                break;

            case 5:
                score.gameObject.SetActive(false);
                scoreText.gameObject.SetActive(false);

                bullet.gameObject.SetActive(true);
                break;

            case 7:
                bullet.gameObject.SetActive(false);

                change.gameObject.SetActive(true);
                break;

            case 8:
                change.gameObject.SetActive(false);

                shield.gameObject.SetActive(true);
                break;

            case 10:
                shield.gameObject.SetActive(false);

                lc.gameObject.SetActive(true);
                break;

            case 13:
                lc.gameObject.SetActive(true);
                shield.gameObject.SetActive(true);
                pause.gameObject.SetActive(true);
                //pausePanel.gameObject.SetActive(true);
                score.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(true);
                bullet.gameObject.SetActive(true);
                //scope.gameObject.SetActive(true);
                //crosshair.gameObject.SetActive(true);
                change.gameObject.SetActive(true);
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
