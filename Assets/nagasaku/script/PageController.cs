using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageController : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("GameOperation2", LoadSceneMode.Single);
    }
}
