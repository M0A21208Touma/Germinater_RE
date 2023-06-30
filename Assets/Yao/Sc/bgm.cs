using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    public bool DontDestroyEnabled = true;

    // Use this for initialization
    void Start()
    {
        if (DontDestroyEnabled)
        {
            // Scene¤òßwÒÆ¤·¤Æ¤â¥ª¥Ö¥¸¥§¥¯¥È¤¬Ïû¤¨¤Ê¤¤¤è¤¦¤Ë¤¹¤ë
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}