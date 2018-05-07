using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewBossSideMissileBoom : MonoBehaviour {

    private void Start()
    {

    }

    private void Update()
    {
        if (Stage4Manager.state == Stage4Manager.State.Back || Stage4Manager.state == Stage4Manager.State.Back)
        {
            Destroy(this.gameObject);
        }

        else
            Destroy(this.gameObject, 1.0f);
    }
}
