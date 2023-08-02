using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemeEndController : MonoBehaviour
{
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}