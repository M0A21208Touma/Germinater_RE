using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript1 : MonoBehaviour
{
    public Image image;
    public float fillAmount;

    private void Start()
    {
        // 初期Fill Amountの設定
        fillAmount=SpilitAction.oriRapid;
    }

    private void Update()
    {
        fillAmount = SpilitAction.oriRapid / 60;
        // Fill Amountを制御する処理を記述する
        // fillAmountの値を変更することでFill Amountが更新される
        // 0から1の範囲内の値を指定する
        image.fillAmount = fillAmount;
    }
}
