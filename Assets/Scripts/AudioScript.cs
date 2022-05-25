using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public static AudioScript audioScriptInstance;


    private void Awake()
    {
        if(audioScriptInstance!=null && audioScriptInstance != this)
        {
            Destroy(this.gameObject);
        }

        audioScriptInstance = this;
        DontDestroyOnLoad(this);
    }
}
