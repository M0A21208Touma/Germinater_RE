using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_3_O : MonoBehaviour
{
    public float speed = 3f;
    public float detectionRange = 5f;
    public int targetx1;
    public int targety1;
    public int targetx2;
    public int targety2;

    public Transform girl;
    private bool isPlayerDetected;

    private GameObject enemy;
    private Vector3 movePosition;
    private bool isMovingToRandomPosition;

    public GameObject prefabToSpawn; // 生成するプレハブ
    public float spawnDistance = 10f; // プレハブを生成する距離

    private bool hasSpawnedPrefab = false;

    private void Start()
    {
        enemy = gameObject;
        movePosition = MoveRandomPosition();
        isMovingToRandomPosition = true;
    }

    private void Update()
    {
        if (isMovingToRandomPosition)
        {
            if (movePosition == enemy.transform.position)
            {
                movePosition = MoveRandomPosition();
            }
            enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, speed * Time.deltaTime);
        }

        // プレイヤーの方向と距離を取得
        Vector3 directionToPlayer = girl.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        // プレイヤーが視界内にいるか確認
        if (distanceToPlayer < detectionRange)
        {
            isPlayerDetected = true;

            if (hasSpawnedPrefab == false) 
            {
                // 敵の位置から指定した距離だけ離れた位置にプレハブを生成
                Vector3 spawnPosition = transform.position + transform.right * spawnDistance;
                GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

                // プレハブをY軸に180度回転
                spawnedPrefab.transform.Rotate(0f, 180f, 0f);
                Debug.Log("Spawn");
                hasSpawnedPrefab = true;
            }

            // プレイヤーに向かって移動
            Vector3 movement = directionToPlayer.normalized * speed * Time.deltaTime;
            transform.position += movement;

            // プレイヤーを追いかける間はランダムな位置を再設定しない
            isMovingToRandomPosition = false;
        }
        else
        {
            isPlayerDetected = false;

            if (!isMovingToRandomPosition)
            {
                isMovingToRandomPosition = true;
                movePosition = MoveRandomPosition();
            }
        }
    }

    private Vector3 MoveRandomPosition()
    {
        Vector3 randomPosi = new Vector3(Random.Range(targetx1, targetx2), Random.Range(targety1, targety2), 0);
        return randomPosi;
    }
}
