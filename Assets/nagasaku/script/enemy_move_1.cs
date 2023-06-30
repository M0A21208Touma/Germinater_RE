using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_1 : MonoBehaviour
{
    public float speed = 3f;
    public float detectionRange = 5f;
    public Transform girl;
    public bool isPlayerDetected;

    private void Update()
    {
        Debug.Log("playerInSight: " + isPlayerDetected);

        // プレイヤーの方向と距離を取得
        Vector3 directionToPlayer = girl.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        // プレイヤーが視界内にいるか確認
        if (distanceToPlayer < detectionRange)
        {
            isPlayerDetected = true;

            // プレイヤーに向かって移動
            Vector3 movement = directionToPlayer.normalized * speed * Time.deltaTime;
            transform.position += movement;
        }
        else
        {
            isPlayerDetected = false;

            // 左に直進
            // Vector3 leftMovement = new Vector3(-1f, 0f, 0f) * speed;
           // transform.position += leftMovement * Time.deltaTime;
        }
    }
}
