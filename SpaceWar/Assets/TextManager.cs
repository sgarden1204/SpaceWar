using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text[] text = new Text[10];

    private int next = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("StartText", 3.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartText()
    {

        text[next].gameObject.SetActive(false);
        text[next + 1].gameObject.SetActive(true);
        next++;

        if(next == 10)
        {
            CancelInvoke();
        }

        //switch(next)
        //{
        //    case 0:
        //        next++;
        //        break;

        //    case 1:
        //        text[next].gameObject.SetActive(false);
        //        next++;
        //        break;

        //    case 2:
        //        text[next].gameObject.SetActive(false);
        //        next++;
        //        break;

        //    case 3:
        //        text[next].gameObject.SetActive(false);
        //        next++;
        //        break;

        //    case 4:

        //        break;

        //    case 5:

        //        break;

        //    case 6:

        //        break;

        //    case 7:

        //        break;

        //    case 8:

        //        break;

        //    case 9:

        //        break;

        //    default:
        //        break;
        //}
    }
}
