using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    public Sprite o1;
    public Sprite o2;
    public Sprite o3;
    public Sprite o4;
    public Sprite o5;
    public Sprite o6;
    public Text Openingtext;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void One()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o1;
        Openingtext.text = "�͂邩�̂ɁA���̐��E�͐��E���Ɏ���Ă����B";
    }
    public void Two()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o2;
        Openingtext.text = "���ǁA�}�ɐ��E���̖\���ɂ��A�X�S�̂ɓŖ����������A�����������������n�߂�";
    }
    public void Three()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o3;
        Openingtext.text = "���E���̋͂��ȑP�ӎ��̎w���ɂ��A���샊�b�g�����o����";
    }
    public void Four()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o4;
        Openingtext.text = " �u���[�c�v�Ƃ������������ׂĂ�߂����͂������āA���̎q�𐢊E���֓������Ƃ�C���ꂽ";
    }
    public void Five()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o5;
        Openingtext.text = "���b�g�ƃ��[�c���o��A���E���̖\�����Ƃ߂邽�ߐ��E���̒��S�ւƌ������̂ł������B";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

