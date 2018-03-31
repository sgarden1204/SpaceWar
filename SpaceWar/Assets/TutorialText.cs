using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

    public Text[] text = new Text[15];

    private int next = 0;

    public Image image;
    public Sprite sprite;
    public Transform panel;

	void Start () {
        InvokeRepeating("StartText", 3.0f, 3.0f);
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
            case 7:

                image.sprite = sprite;
                break;

            case 12:
                panel.gameObject.SetActive(false);
                CancelInvoke();
                break;
            default:
                break;
        }
    }
}
