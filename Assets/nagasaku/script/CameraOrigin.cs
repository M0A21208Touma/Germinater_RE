using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraOrigin : MonoBehaviour
{
    public Button button1;
    public Button button2;
    // Start is called before the first frame update
    public void MoveCameraToPosition2()
    {
        // �J�����̈ړ���ʒu���w��
        Vector3 targetPosition = new Vector3(0f, 0f, -10f);

        // �J�����̈ړ�����
        Camera.main.transform.position = targetPosition;

        // �{�^���̕\������
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);
    }
}
