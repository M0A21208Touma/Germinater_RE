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

            // 衝突した位置にWindオブジェクトを生成
            GameObject wind = Instantiate(Wind, collision.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            // 2秒後にWindオブジェクトを破棄
            Destroy(wind, 2f);
            isWind = true;
        }
    }
}
