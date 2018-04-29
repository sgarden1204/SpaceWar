using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialUIManager : MonoBehaviour
{

    public static int goalCount = 0;

    public AudioClip clip;

    public Image bulletImg;
    public Sprite raser;
    public Sprite missile;
    public Sprite machinegun;

    private int weaponChange = 0;

    // Use this for initialization
    void Start()
    {
        AudioManager.Instance().PlayClip(clip);
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
    }

    public void NextScene()
    {
        SceneManager.LoadScene("TutorialFireAndMove");
    }
}
