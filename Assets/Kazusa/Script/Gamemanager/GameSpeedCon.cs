using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedCon : MonoBehaviour
{
    public Transform targetPosition; // �Q�[���X�s�[�h�����ɖ߂��ʒu��Transform
    public int dist;
    public GameObject sT;
    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            // �}�E�X�̈ʒu���擾
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            // ����̈ʒu�Ƀ}�E�X���ړ������ꍇ�A�Q�[���X�s�[�h�����ɖ߂�
            if (Vector3.Distance(mousePosition, targetPosition.position) < dist)
            {
                Time.timeScale = 1f;
                sT.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
