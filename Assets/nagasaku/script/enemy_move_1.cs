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

        // �v���C���[�̕����Ƌ������擾
        Vector3 directionToPlayer = girl.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        // �v���C���[�����E���ɂ��邩�m�F
        if (distanceToPlayer < detectionRange)
        {
            isPlayerDetected = true;

            // �v���C���[�Ɍ������Ĉړ�
            Vector3 movement = directionToPlayer.normalized * speed * Time.deltaTime;
            transform.position += movement;
        }
        else
        {
            isPlayerDetected = false;

            // ���ɒ��i
            // Vector3 leftMovement = new Vector3(-1f, 0f, 0f) * speed;
           // transform.position += leftMovement * Time.deltaTime;
        }
    }
}
