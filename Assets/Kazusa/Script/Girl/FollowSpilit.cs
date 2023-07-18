using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpilit : MonoBehaviour
{
    public Transform target; // 追従させたいオブジェクト

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            // 追従させたいオブジェクトの座標を取得し、UIオブジェクトに反映する
            rectTransform.position = Camera.main.WorldToScreenPoint(target.position);
        }
    }
}
