using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewTextManager : MonoBehaviour
{
    public Transform panel;

    public Text[] text = new Text[15];

    private int next = 0;

    public Image image;
    public Sprite sprite;

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
                image.sprite = sprite;
                break;

            case 14:
                panel.gameObject.SetActive(false);
                CancelInvoke();
                Invoke("NextScene", 3.0f);
                break;
            default:
                break;
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Stage4");
    }
}
