using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    private static BGMusic music;
    private void Awake()
    {
        if(music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
