using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage3Manager : MonoBehaviour
{

    public AudioClip clip;

    public Image bulletImg;
    public Sprite raser;
    public Sprite missile;
    public Sprite machinegun;

    public Image[] imgPowerUp = new Image[3];

    private int weaponChange = 0;

    // Use this for initialization
    void Start()
    {
        //AudioManager.Instance().PlayClip(clip);

        //if(AudioManager.Instance() == null)
        //{

        //}
        GetComponent<AudioSource>().PlayOneShot(clip, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            switch (weaponChange)
            {
                case 0:
                    bulletImg.sprite = raser;
                    weaponChange++;
                    break;
                case 1:
                    bulletImg.sprite = machinegun;
                    weaponChange++;
                    break;
                case 2:
                    bulletImg.sprite = missile;
                    weaponChange = 0;
                    break;
            }
        }

        switch(TopViewPlayerFire.powerUpCount)
        {
            case 0:

                break;

            case 1:
                imgPowerUp[0].gameObject.SetActive(true);
                break;

            case 2:
                imgPowerUp[1].gameObject.SetActive(true);
                break;

            case 3:
                imgPowerUp[2].gameObject.SetActive(true);
                break;

            default:
                break;
        }
    }
}