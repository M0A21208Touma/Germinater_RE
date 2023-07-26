using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController2 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("GameOperation", LoadSceneMode.Single);
    }
}
