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
        Openingtext.text = "�Ϥ뤫���ˡ�����������������ؤ��Ƥ�����";
    }  public void Two()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o2;
        Openingtext.text = "���ɡ����������α��ߤˤ�ꡢɭȫ��˶��F�����Ӥ������錄������Ҥ�ʼ�᤿";
    } public void Three()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o3;
        Openingtext.text = "�����΃H���������R��ָʾ�ˤ�ꡢ��둥�åȤ����������";
    }
    public void Four()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o4;
        Openingtext.text = " ����`�ġ��Ȥ�����Ů�����٤Ƥ�����������֤äơ������Ӥ������،������Ȥ��Τ��줿";
    }
    public void Five()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o5;
        Openingtext.text = "��åȤȥ�`�Ĥ����ᤤ�������α��ߤ�Ȥ�뤿�����������Ĥؤ��򤫤��ΤǤ��ä���";
    }
 
    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
    }

