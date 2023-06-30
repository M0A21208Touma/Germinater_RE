using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedRotate : MonoBehaviour
{
    private Transform parentTransform;
    private Quaternion initialLocalRotation;

    private void Start()
    {
        parentTransform = transform.parent;
        initialLocalRotation = transform.localRotation;
    }

    private void LateUpdate()
    {
        transform.position = parentTransform.position;
        transform.rotation = parentTransform.rotation * initialLocalRotation;
    }
}







