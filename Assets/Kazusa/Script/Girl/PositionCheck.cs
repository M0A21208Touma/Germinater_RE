using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheck : MonoBehaviour
{
    public Transform Girl;
    public Transform houkou;
    public static float angle;
    void Update()
    {
        // オブジェクトAとBの位置を取得
        Vector3 positionA = Girl.position;
        Vector3 positionB = houkou.position;

        // オブジェクトAからオブジェクトBへの方向を計算
        Vector3 direction = positionB - positionA;
         angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 方向を可視化する処理（例：角度をログで表示）
    }
}
