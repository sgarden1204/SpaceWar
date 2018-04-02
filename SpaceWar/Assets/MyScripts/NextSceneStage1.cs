using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneStage1 : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Stage1 Enter!");
        SceneManager.LoadScene("Stage1");
    }
}
