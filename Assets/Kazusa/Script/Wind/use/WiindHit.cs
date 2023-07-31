using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiindHit : MonoBehaviour
{
    public GameObject Wind;
    public static bool isWind;

    public void Start()
    {
        isWind = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")||collision.CompareTag("Flower"))
        {

            // �Փ˂����ʒu��Wind�I�u�W�F�N�g�𐶐�
            GameObject wind = Instantiate(Wind, collision.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            // 2�b���Wind�I�u�W�F�N�g��j��
            Destroy(wind, 2f);
            isWind = true;
        }
    }
}
