using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NectScene : MonoBehaviour
{
   private int  iLevel ;  
    // Start is called before the first frame update
    void Start()
    {
        iLevel = SceneManager.GetActiveScene().buildIndex; �@�@//�ϐ�iLevel�Ɍ��݂�Level��index�ԍ�����荞�݂܂�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene()                                // ���̃V�[���ɐi�߂郁�\�b�h�ł�
    {
        iLevel++;                                                       //�@�ϐ�iLevel��1�𑫂��܂�
        SceneManager.LoadScene(iLevel);�@�@//�@���̃��x���V�[�������[�h���܂�
    }
}
