using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    Transform tf; //Main Camera��Transform
    private float x = 21.2f;
    public Text dialogueText; // ����դ��ʾ����ƥ�����UI
    public string[] dialogues; // ����դ�����
    private int currentDialogueIndex = 0; // �F�ڱ�ʾ���Ƥ��륻��դΥ���ǥå���
    public Text Openingtext;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main Camera��Transform��ȡ�ä��롣                                                     
        ShowDialogue(); // ����Υ���դ��ʾ
    }

    // Update is called once per frame
    void Update()
    {
         float X= this.gameObject.GetComponent<Transform>().position.x;
        if (Input.GetMouseButtonDown(0))
        {
            tf.position = new Vector3(X+x, 0.0f,-10f);
        }

        // �󥯥�å����줿��ΤΥ���դ��ʾ
        if (Input.GetMouseButtonDown(0))
        {
            currentDialogueIndex++;
            // ����դ򤹤٤Ʊ�ʾ�������ϡ�����������Ǳ�ʾ�ˤ���
            if (currentDialogueIndex >= dialogues.Length)
            {
                HideDialogue();
            }
            else
            {
                ShowDialogue();
            }
        }
    }
    private void ShowDialogue()
    {
        // ����դ��ʾ
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    private void HideDialogue()
    {
        // ����������Ǳ�ʾ�ˤ��루�����Хƥ����Ȥ򥯥ꥢ���룩
        dialogueText.text = "";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

