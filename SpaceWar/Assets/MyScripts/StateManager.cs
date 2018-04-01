using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

    public static StateManager stateInstance = null;

    public static StateManager Instace()
    {
        return stateInstance;
    }

    public enum gamestate { gameplay, gamestop};
    public gamestate currentState = gamestate.gamestop;

    private void Start()
    {
        if(stateInstance != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            stateInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
