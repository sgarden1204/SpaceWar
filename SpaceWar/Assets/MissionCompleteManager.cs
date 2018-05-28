using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissionCompleteManager : MonoBehaviour {

    public Text missionText;

    public Text yourRankText;
    public Text showRankText;
    public Text yourScoreText;
    public Text showScoreText;

    public Image showAIImg;
    public Image showAITextImg;
    public Text showAIText;

    public AudioClip victoty;
    public AudioClip missionClear;

    private int callCount;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CallWord",0.4f,0.4f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CallWord()
    {
        callCount++;

        switch(callCount)
        {
            case 1:
                GetComponent<AudioSource>().PlayOneShot(missionClear);
                missionText.gameObject.SetActive(true);
                missionText.text = "M";
                missionText.color = Color.red;
                break;
            case 2:
                missionText.text = "Mi";
                missionText.color = Color.green;
                break;
            case 3:
                missionText.text = "Mis";
                missionText.color = Color.blue;
                break;
            case 4:
                missionText.text = "Miss";
                missionText.color = Color.yellow;
                break;
            case 5:
                missionText.text = "Missi";
                missionText.color = Color.black;
                break;
            case 6:
                missionText.text = "Missio";
                missionText.color = Color.cyan;
                break;
            case 7:
                missionText.text = "Mission";
                missionText.color = Color.grey;
                break;
            case 8:
                missionText.text = "Mission ";
                missionText.color = Color.magenta;
                break;
            case 9:
                missionText.text = "Mission C";
                missionText.color = Color.white;
                break;
            case 10:
                missionText.text = "Mission Co";
                missionText.color = Color.red;
                break;
            case 11:
                missionText.text = "Mission Com";
                missionText.color = Color.green;
                break;
            case 12:
                missionText.text = "Mission Comp";
                missionText.color = Color.blue;
                break;
            case 13:
                missionText.text = "Mission Compl";
                missionText.color = Color.yellow;
                break;
            case 14:
                missionText.text = "Mission Comple";
                missionText.color = Color.magenta;
                break;
            case 15:
                missionText.text = "Mission Complet";
                missionText.color = Color.cyan;
                break;
            case 16:
                missionText.text = "Mission Complete";
                missionText.color = Color.black;
                break;
            case 17:
                missionText.text = "Mission Complete!";
                missionText.color = Color.white;
                //hex Color 32DA55FF;
                //50,218,85,255
                break;

            case 18:
                
                yourRankText.gameObject.SetActive(true);
                //Your Rank
                break;

            case 19:
                showRankText.gameObject.SetActive(true);
                //Show Rank
                break;

            case 20:
                yourScoreText.gameObject.SetActive(true);

                if(ScoreManager.Instance() != null)
                {
                    int score = ScoreManager.score;
                    yourScoreText.text = score.ToString("D8");
                }

                else
                {
                    int score = 263547;
                    yourScoreText.text = score.ToString("D8");
                }
                //Your Score
                break;

            case 21:
                showScoreText.gameObject.SetActive(true);
                //Show Score
                break;

            case 22:
                showAIImg.gameObject.SetActive(true);
                //Show AI Img
                break;

            case 23:
                showAITextImg.gameObject.SetActive(true);
                //Show Text Img
                break;

            case 24:
                showAIText.gameObject.SetActive(true);
                GetComponent<AudioSource>().PlayOneShot(victoty);
                //Show AI Text
                break;

            case 25:
                //Show Return Title button
                //Show Next Stage Button
                break;

            default:
                CancelInvoke();
                break;
        }
    }

    public void ReturnTitle()
    {
        SceneManager.LoadScene("Main");
    }

    public void NextStage()
    {
        SceneManager.LoadScene("Stage3");
    }
}
