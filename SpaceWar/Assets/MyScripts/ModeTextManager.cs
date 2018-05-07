using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTextManager : MonoBehaviour
{
    public Transform panel;

    public Text[] text = new Text[6];

    private int next = 0;


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
            case 5:
                panel.gameObject.SetActive(false);
                CancelInvoke();
                break;
            default:
                break;
        }
    }
}
