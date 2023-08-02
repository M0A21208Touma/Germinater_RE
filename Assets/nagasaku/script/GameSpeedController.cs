using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSpeedController : MonoBehaviour
{
    private bool isGamePaused = false;
    private float originalTimeScale;
    private string targetSceneName = "StageSelect"; // �J�ڂ������V�[���̖��O���w��

    [SerializeField] private GameObject darkPanel; // �Â�����p�l�����w�肷�邽�߂̕ϐ�

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
            SceneManager.LoadScene(targetSceneName); // �G���^�[�L�[�Ŏw��̃V�[���ɑJ��
        }
    }

    void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0f;

        if (darkPanel != null)
            darkPanel.SetActive(true); // �Â�����p�l�����A�N�e�B�u�ɂ���
    }

    void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f;

        if (darkPanel != null)
            darkPanel.SetActive(false); // �Â�����p�l�����A�N�e�B�u�ɂ���
    }
}
