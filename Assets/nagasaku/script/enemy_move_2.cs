using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move_2 : MonoBehaviour
{
    public float rotationSpeed = 5f; // ��]���x
    public float detectionRange = 10f; // �v���C���[�����m����͈�
    public float chargeDistance = 5f; // �ːi���鋗��
    public float movementSpeed = 10f; // �ːi���x
    public float fieldOfView = 30f; // ����p�x
    public float initialViewAngle = -90f; // ��������̊p�x

    private Transform player; // �v���C���[��Transform
    private bool playerDetected; // �v���C���[�����m�������ǂ���
    private bool isFrozen;
    private float freezeDuration = 3f;
    private float freezeTimer;

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

            // �v���C���[�����m�͈͓��ɂ���ꍇ������p�x���ɂ���ꍇ
            if (distanceToPlayer <= detectionRange && IsPlayerInFieldOfView())
            {
                // �v���C���[�����m�����ꍇ
                if (!playerDetected)
                {
                    playerDetected = true;
                    RotateTowardsPlayer();
                }

                // �ːi����
                ChargeForward();
            }
            else
            {
                // �v���C���[�����m�͈͊O�̏ꍇ
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
        // �v���C���[�̕���������
        Vector3 direction = (player.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 eulerRotation = targetRotation.eulerAngles;
        eulerRotation.x = 0f;
        eulerRotation.y = 0f;
        eulerRotation.z += initialViewAngle; // ����̈ʒu����������̊p�x�ɕύX
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(eulerRotation), rotationSpeed * Time.deltaTime);
    }

    private void ChargeForward()
    {
        // �ːi���鋗���ɓ��B����܂őO�i
        transform.position += transform.up * movementSpeed * Time.deltaTime;

        // �ːi�����ɓ��B�����ꍇ
        float distanceToTarget = Vector3.Distance(transform.position, player.position);
        if (distanceToTarget <= chargeDistance)
        {
            // �ːi���I�����A�ēx�v���C���[�����m����܂Ń��Z�b�g
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