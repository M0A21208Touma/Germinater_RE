using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    Transform tf; //Main Camera��Transform
    private float x = 21.2f;
    public Text dialogueText; // ����Eդ��澤���Eƥ�����UI
    public string[] dialogues; // ����Eդ�����
    private int currentDialogueIndex = 0; // �F�ڱ�澤��Ƥ���E���EդΥ���ǥå���
    public Text Openingtext;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main Camera��Transform��ȡ�ä���E�                                                     
        ShowDialogue(); // �����Υ���Eդ���
    }

    // Update is called once per frame
    void Update()
    {
         float X= this.gameObject.GetComponent<Transform>().position.x;
        if (Input.GetMouseButtonDown(0))
        {
            tf.position = new Vector3(X+x, 0.0f,-10f);
        }

        // �󥯥�Eå�����E���ΤΥ���Eդ���
        if (Input.GetMouseButtonDown(0))
        {
            currentDialogueIndex++;
            // ����Eդ򤹤٤Ʊ�澤������ϡ�������������Ǳ�澤ˤ���E
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
        // ����Eդ���
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    private void HideDialogue()
    {
        // ������������Ǳ�澤ˤ���E������Хƥ����Ȥ򥯥�E�����E�
        dialogueText.text = "";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

