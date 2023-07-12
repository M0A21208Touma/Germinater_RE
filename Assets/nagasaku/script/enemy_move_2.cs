using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_2 : MonoBehaviour
{
    public float rotationSpeed = 5f; // 回転速度
    public float detectionRange = 10f; // プレイヤーを検知する範囲
    public float chargeDistance = 5f; // 突進する距離
    public float movementSpeed = 10f; // 突進速度
    public float fieldOfView = 30f; // 視野角度
    public float initialViewAngle = -90f; // 初期視野の角度

    private Transform player; // プレイヤーのTransform
    private bool playerDetected; // プレイヤーを検知したかどうか
    private bool isFrozen;
    private float freezeDuration = 3f;
    private float freezeTimer;

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

            // プレイヤーが検知範囲内にいる場合かつ視野角度内にいる場合
            if (distanceToPlayer <= detectionRange && IsPlayerInFieldOfView())
            {
                // プレイヤーを検知した場合
                if (!playerDetected)
                {
                    playerDetected = true;
                    RotateTowardsPlayer();
                }

                // 突進する
                ChargeForward();
            }
            else
            {
                // プレイヤーが検知範囲外の場合
                playerDetected = false;
            }
        }
        if (isFrozen)
        {
            freezeTimer -= Time.deltaTime;
            if (freezeTimer <= 0f)
            {
                isFrozen = false;
                playerDetected = false;
            }
            return;
        }
    }

    private bool IsPlayerInFieldOfView()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        float angle = Vector3.Angle(transform.up, directionToPlayer);
        return angle <= fieldOfView * 0.5f;
    }

    private void RotateTowardsPlayer()
    {
        // プレイヤーの方向を向く
        Vector3 direction = (player.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 eulerRotation = targetRotation.eulerAngles;
        eulerRotation.x = 0f;
        eulerRotation.y = 0f;
        eulerRotation.z += initialViewAngle; // 視野の位置を初期視野の角度に変更
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(eulerRotation), rotationSpeed * Time.deltaTime);
    }

    private void ChargeForward()
    {
        // 突進する距離に到達するまで前進
        transform.position += transform.up * movementSpeed * Time.deltaTime;

        // 突進距離に到達した場合
        float distanceToTarget = Vector3.Distance(transform.position, player.position);
        if (distanceToTarget <= chargeDistance)
        {
            // 突進を終了し、再度プレイヤーを検知するまでリセット
            playerDetected = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wind"))
        {
            isFrozen = true;
            freezeTimer = freezeDuration;
            StopMovement();
        }
        else if (collision.CompareTag("Wall") && isFrozen)
        {
            freezeTimer += 2f;
            Debug.Log("+2");
        }
    }
    private void StopMovement()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
    }
}