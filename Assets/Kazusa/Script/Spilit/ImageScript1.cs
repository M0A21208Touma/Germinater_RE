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
        // ����Fill Amount�̐ݒ�
        fillAmount=SpilitAction.oriRapid;
    }

    private void Update()
    {
        fillAmount = SpilitAction.oriRapid / 60;
        // Fill Amount�𐧌䂷�鏈�����L�q����
        // fillAmount�̒l��ύX���邱�Ƃ�Fill Amount���X�V�����
        // 0����1�͈͓̔��̒l���w�肷��
        image.fillAmount = fillAmount;
    }
}
