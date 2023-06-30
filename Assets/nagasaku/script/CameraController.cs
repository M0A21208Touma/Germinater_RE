using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public void MoveCameraToPosition1()
    {
        // カメラの移動先位置を指定
        Vector3 targetPosition = new Vector3(24f, 0f, -10f);

        // カメラの移動処理
        Camera.main.transform.position = targetPosition;

        // ボタンの表示制御
        //button1.gameObject.SetActive(false);
        //button2.gameObject.SetActive(true);
    }
    public void MoveCameraToPosition2()
    {
        // カメラの移動先位置を指定
        Vector3 targetPosition = new Vector3(0f, 0f, -10f);

        // カメラの移動処理
        Camera.main.transform.position = targetPosition;

        // ボタンの表示制御
        //button1.gameObject.SetActive(true);
        //button2.gameObject.SetActive(false);
    }
}
