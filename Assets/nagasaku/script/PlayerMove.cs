using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Update()
    {
        // ���͂̎擾
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // �ړ��x�N�g���̌v�Z
        Vector3 moveDirection = new Vector3(moveX, moveY, 0f);

        // �ړ��x�N�g���̐��K��
        moveDirection.Normalize();

        // �ړ�����
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}