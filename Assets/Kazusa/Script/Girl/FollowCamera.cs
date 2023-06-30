using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // �Ǐ]�Ώۂ̃L�����N�^�[��Transform
    private Vector3 offset; // �J�����̑��ΓI�Ȉʒu�I�t�Z�b�g

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            targetPosition.z = transform.position.z; // �J������z���ʒu��ς��Ȃ��悤�ɂ���
            transform.position = targetPosition;
        }
    }
}
