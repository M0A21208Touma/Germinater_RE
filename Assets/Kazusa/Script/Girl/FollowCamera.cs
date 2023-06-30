using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // 追従対象のキャラクターのTransform
    private Vector3 offset; // カメラの相対的な位置オフセット

    void Start()
    {
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position + offset;
            targetPosition.z = transform.position.z; // カメラのz軸位置を変えないようにする
            transform.position = targetPosition;
        }
    }
}
