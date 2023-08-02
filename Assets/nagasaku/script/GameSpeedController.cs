using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSpeedController : MonoBehaviour
{
    private bool isGamePaused = false;
    private float originalTimeScale;
    private string targetSceneName = "StageSelect"; // 遷移したいシーンの名前を指定

    [SerializeField] private GameObject darkPanel; // 暗くするパネルを指定するための変数

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (isGamePaused && Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(targetSceneName); // エンターキーで指定のシーンに遷移
        }
    }

    void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0f;

        if (darkPanel != null)
            darkPanel.SetActive(true); // 暗くするパネルをアクティブにする
    }

    void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f;

        if (darkPanel != null)
            darkPanel.SetActive(false); // 暗くするパネルを非アクティブにする
    }
}
