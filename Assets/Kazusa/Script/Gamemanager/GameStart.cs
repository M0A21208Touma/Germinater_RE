using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private void OnMouseEnter()
    {
        if (Time.timeScale != 1f)
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }
        Debug.Log("ddd");
    }
}
