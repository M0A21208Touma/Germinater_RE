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
        // 入力の取得
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // 移動ベクトルの計算
        Vector3 moveDirection = new Vector3(moveX, moveY, 0f);

        // 移動ベクトルの正規化
        moveDirection.Normalize();

        // 移動処理
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}