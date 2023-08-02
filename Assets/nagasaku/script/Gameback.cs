using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameback : MonoBehaviour
{
    private bool isGamePaused = false;
    [SerializeField] private GameObject darkPanel; // 暗くするパネルを指定するための変数
    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f;

        if (darkPanel != null)
            darkPanel.SetActive(false); // 暗くするパネルを非アクティブにする
    }
}
