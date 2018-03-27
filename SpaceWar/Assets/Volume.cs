using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {

    public static float volumeOption = 1.0f;

	void Update () {

        AudioListener.volume = volumeOption;
	}
}
