using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flont : MonoBehaviour
{  // 変更するプレイヤーのOrder in Layer
    public int newOrderInLayer = 2;

    // トリガーコライダーとの接触判定
    public bool isTriggered = false;

    // プレイヤーの元のOrder in Layer
    private int originalOrderInLayer;

    // 初期化
    private void Start()
    {
        // プレイヤーの元のOrder in Layerを保存する
        originalOrderInLayer = GetComponent<SpriteRenderer>().sortingOrder;
    }

    // トリガーコライダーに入ったときに呼び出されるコールバック
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Treetagオブジェクトとの衝突判定
        if (other.CompareTag("Tree"))
        {
            isTriggered = true;
            ChangePlayerOrder();
        }
    }

    // トリガーコライダーから出たときに呼び出されるコールバック
    private void OnTriggerExit2D(Collider2D other)
    {
        // Treetagオブジェクトとの衝突判定
        if (other.CompareTag("Tree"))
        {
            isTriggered = false;
            ChangePlayerOrder();
        }
    }

    // プレイヤーのOrder in Layerを変更する関数
    private void ChangePlayerOrder()
    {
        // プレイヤーのSpriteRendererを取得する
        SpriteRenderer playerSpriteRenderer = GetComponent<SpriteRenderer>();

        // プレイヤーのOrder in Layerを変更する
        playerSpriteRenderer.sortingOrder = isTriggered ? newOrderInLayer : originalOrderInLayer;
    }
}
