using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flont : MonoBehaviour
{  // �ύX����v���C���[��Order in Layer
    public int newOrderInLayer = 2;

    // �g���K�[�R���C�_�[�Ƃ̐ڐG����
    public bool isTriggered = false;

    // �v���C���[�̌���Order in Layer
    private int originalOrderInLayer;

    // ������
    private void Start()
    {
        // �v���C���[�̌���Order in Layer��ۑ�����
        originalOrderInLayer = GetComponent<SpriteRenderer>().sortingOrder;
    }

    // �g���K�[�R���C�_�[�ɓ������Ƃ��ɌĂяo�����R�[���o�b�N
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Treetag�I�u�W�F�N�g�Ƃ̏Փ˔���
        if (other.CompareTag("Tree"))
        {
            isTriggered = true;
            ChangePlayerOrder();
        }
    }

    // �g���K�[�R���C�_�[����o���Ƃ��ɌĂяo�����R�[���o�b�N
    private void OnTriggerExit2D(Collider2D other)
    {
        // Treetag�I�u�W�F�N�g�Ƃ̏Փ˔���
        if (other.CompareTag("Tree"))
        {
            isTriggered = false;
            ChangePlayerOrder();
        }
    }

    // �v���C���[��Order in Layer��ύX����֐�
    private void ChangePlayerOrder()
    {
        // �v���C���[��SpriteRenderer���擾����
        SpriteRenderer playerSpriteRenderer = GetComponent<SpriteRenderer>();

        // �v���C���[��Order in Layer��ύX����
        playerSpriteRenderer.sortingOrder = isTriggered ? newOrderInLayer : originalOrderInLayer;
    }
}
