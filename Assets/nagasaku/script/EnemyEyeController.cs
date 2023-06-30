using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEyeController : MonoBehaviour
{
    public Transform eyeTransform;  // �ڂƂȂ�q�I�u�W�F�N�g��Transform
    public float rotationSpeed = 5f; // ��]���x

    private Transform target; // �v���C���[��Transform

    private void Start()
    {
        // �v���C���[�������邽�߂̃^�O "Player" �����I�u�W�F�N�g������
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }

    private void Update()
    {
        if (target != null)
        {
            // �ڕW�������擾
            Vector3 targetDirection = target.position - eyeTransform.position;

            // �ڕW�����ւ̉�]���v�Z
            Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, targetDirection);

            // �ڕW�����ɂ������Ɖ�]
            eyeTransform.rotation = Quaternion.Lerp(eyeTransform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
