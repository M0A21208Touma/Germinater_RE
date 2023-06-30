using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedCon : MonoBehaviour
{
    public Transform targetPosition; // ゲームスピードを元に戻す位置のTransform
    public int dist;
    public GameObject sT;
    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            // マウスの位置を取得
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            // 特定の位置にマウスが移動した場合、ゲームスピードを元に戻す
            if (Vector3.Distance(mousePosition, targetPosition.position) < dist)
            {
                Time.timeScale = 1f;
                sT.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
