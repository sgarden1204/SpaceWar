using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SysnopsisText : MonoBehaviour {

    public Text[] text = new Text[11];

    private int next = 0;

    public Image image;
    public Sprite[] sprite = new Sprite[2];

	// Use this for initialization
	void Start () {

        InvokeRepeating("StartText", 3.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
        if(next == 10)
        {
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene("Tutorial");
            }
        }

	}

    void StartText()
    {

        text[next].gameObject.SetActive(false);
        next++;
        text[next].gameObject.SetActive(true);

        switch(next)
        {
            case 2:

                image.sprite = sprite[0];
                break;

            case 5:
                image.sprite = sprite[1];
                break;

            case 10:
                CancelInvoke();
                break;
            default:
                break;
        }

    }
}
