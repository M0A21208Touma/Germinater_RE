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
        // �J�����̈ړ���ʒu���w��
        Vector3 targetPosition = new Vector3(24f, 0f, -10f);

        // �J�����̈ړ�����
        Camera.main.transform.position = targetPosition;

        // �{�^���̕\������
        //button1.gameObject.SetActive(false);
        //button2.gameObject.SetActive(true);
    }
    public void MoveCameraToPosition2()
    {
        // �J�����̈ړ���ʒu���w��
        Vector3 targetPosition = new Vector3(0f, 0f, -10f);

        // �J�����̈ړ�����
        Camera.main.transform.position = targetPosition;

        // �{�^���̕\������
        //button1.gameObject.SetActive(true);
        //button2.gameObject.SetActive(false);
    }
}
