using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpilit : MonoBehaviour
{
    public Transform target; // �Ǐ]���������I�u�W�F�N�g

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            // �Ǐ]���������I�u�W�F�N�g�̍��W���擾���AUI�I�u�W�F�N�g�ɔ��f����
            rectTransform.position = Camera.main.WorldToScreenPoint(target.position);
        }
    }
}
