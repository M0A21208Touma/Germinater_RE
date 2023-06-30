using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_2 : MonoBehaviour
{
    public float movementSpeed = 5f; // 移動速度
    public float detectionRange = 10f; // プレイヤーを検知する範囲

    private Transform player; // プレイヤーのTransform

    private void Start()
    {
        // プレイヤーを見つけるためのタグ "Player" を持つオブジェクトを検索
        GameObject playerObject = GameObject.FindGameObjectWithTag("Girl");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            // プレイヤーとの距離を計算
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // プレイヤーが検知範囲内にいる場合は突進する
            if (distanceToPlayer <= detectionRange)
            {
                // プレイヤーの方向を向く
                Vector3 direction = (player.position - transform.position).normalized;
                transform.up = direction;

                // 突進する
                transform.position += direction * movementSpeed * Time.deltaTime;
            }
        }
    }
}
