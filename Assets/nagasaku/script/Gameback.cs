using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameback : MonoBehaviour
{
    private bool isGamePaused = false;
    [SerializeField] private GameObject darkPanel; // �Â�����p�l�����w�肷�邽�߂̕ϐ�
    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1f;

        if (darkPanel != null)
            darkPanel.SetActive(false); // �Â�����p�l�����A�N�e�B�u�ɂ���
    }
}
