using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_2 : MonoBehaviour
{
    public float movementSpeed = 5f; // �ړ����x
    public float detectionRange = 10f; // �v���C���[�����m����͈�

    private Transform player; // �v���C���[��Transform

    private void Start()
    {
        // �v���C���[�������邽�߂̃^�O "Player" �����I�u�W�F�N�g������
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
            // �v���C���[�Ƃ̋������v�Z
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // �v���C���[�����m�͈͓��ɂ���ꍇ�͓ːi����
            if (distanceToPlayer <= detectionRange)
            {
                // �v���C���[�̕���������
                Vector3 direction = (player.position - transform.position).normalized;
                transform.up = direction;

                // �ːi����
                transform.position += direction * movementSpeed * Time.deltaTime;
            }
        }
    }
}
