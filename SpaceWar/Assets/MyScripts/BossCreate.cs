using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCreate : MonoBehaviour {

    public GameObject sideBoss;
    public Slider bossSlider;
    public Transform player;

    public float distance = 10.0f;

    private GameObject boss;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            bossSlider.gameObject.SetActive(true);
            boss = Instantiate(sideBoss, player.position, player.rotation);
            boss.transform.position = new Vector3(player.position.x, player.position.y, player.position.z + distance);
            boss.transform.Rotate(0.0f, -180.0f, 0.0f);
        }
    }
}
