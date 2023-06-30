using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEyeController : MonoBehaviour
{
    public Transform eyeTransform;  // 目となる子オブジェクトのTransform
    public float rotationSpeed = 5f; // 回転速度

    private Transform target; // プレイヤーのTransform

    private void Start()
    {
        // プレイヤーを見つけるためのタグ "Player" を持つオブジェクトを検索
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }

    private void Update()
    {
        if (target != null)
        {
            // 目標方向を取得
            Vector3 targetDirection = target.position - eyeTransform.position;

            // 目標方向への回転を計算
            Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, targetDirection);

            // 目標方向にゆっくりと回転
            eyeTransform.rotation = Quaternion.Lerp(eyeTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
