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

    public GameObject prefabToSpawn; // ��������v���n�u
    public float spawnDistance = 10f; // �v���n�u�𐶐����鋗��

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

        // �v���C���[�̕����Ƌ������擾
        Vector3 directionToPlayer = girl.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        // �v���C���[�����E���ɂ��邩�m�F
        if (distanceToPlayer < detectionRange)
        {
            isPlayerDetected = true;

            if (hasSpawnedPrefab == false) 
            {
                // �G�̈ʒu����w�肵�������������ꂽ�ʒu�Ƀv���n�u�𐶐�
                Vector3 spawnPosition = transform.position + transform.right * spawnDistance;
                GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

                // �v���n�u��Y����180�x��]
                spawnedPrefab.transform.Rotate(0f, 180f, 0f);
                Debug.Log("Spawn");
                hasSpawnedPrefab = true;
            }

            // �v���C���[�Ɍ������Ĉړ�
            Vector3 movement = directionToPlayer.normalized * speed * Time.deltaTime;
            transform.position += movement;

            // �v���C���[��ǂ�������Ԃ̓����_���Ȉʒu���Đݒ肵�Ȃ�
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
