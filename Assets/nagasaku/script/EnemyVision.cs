using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public GameObject prefabToSpawn; // ��������v���n�u
    public float spawnDistance = 10f; // �v���n�u�𐶐����鋗��

    private bool hasSpawnedPrefab = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasSpawnedPrefab && collision.CompareTag("Girl"))
        {
            // �G�̈ʒu����w�肵�������������ꂽ�ʒu�Ƀv���n�u�𐶐�
            Vector3 spawnPosition = transform.position + transform.right * spawnDistance;
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            hasSpawnedPrefab = true;
        }
    }
}