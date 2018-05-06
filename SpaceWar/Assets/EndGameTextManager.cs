using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameTextManager : MonoBehaviour
{
    public Transform panel;

    public Text[] text = new Text[15];

    private int next = 0;

    public Image image;
    public Sprite[] sprite = new Sprite[2];

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
            case 2:
                image.sprite = sprite[1];
                break;

            case 5:
                panel.gameObject.SetActive(false);
                CancelInvoke();
                break;
            default:
                break;
        }
    }
}
