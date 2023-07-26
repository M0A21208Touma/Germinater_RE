using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public GameObject prefabToSpawn; // 生成するプレハブ
    public float spawnDistance = 10f; // プレハブを生成する距離

    private bool hasSpawnedPrefab = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasSpawnedPrefab && collision.CompareTag("Girl"))
        {
            // 敵の位置から指定した距離だけ離れた位置にプレハブを生成
            Vector3 spawnPosition = transform.position + transform.right * spawnDistance;
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            hasSpawnedPrefab = true;
        }
    }
}