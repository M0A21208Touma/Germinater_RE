using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheck : MonoBehaviour
{
    public Transform Girl;
    public Transform houkou;
    public static float angle;
    void Update()
    {
        // �I�u�W�F�N�gA��B�̈ʒu���擾
        Vector3 positionA = Girl.position;
        Vector3 positionB = houkou.position;

        // �I�u�W�F�N�gA����I�u�W�F�N�gB�ւ̕������v�Z
        Vector3 direction = positionB - positionA;
         angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // �������������鏈���i��F�p�x�����O�ŕ\���j
    }
}
