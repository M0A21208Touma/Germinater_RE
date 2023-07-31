using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    Transform tf; //Main CameraのTransform
    private float x = 21.2f;
    public Text dialogueText; // セリフを燕幣するテキストUI
    public string[] dialogues; // セリフの塘双
    private int currentDialogueIndex = 0; // �F壓燕幣しているセリフのインデックス
    public Text Openingtext;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを函誼する。                                                     
        ShowDialogue(); // 恷兜のセリフを燕幣
    }

    // Update is called once per frame
    void Update()
    {
         float X= this.gameObject.GetComponent<Transform>().position.x;
        if (Input.GetMouseButtonDown(0))
        {
            tf.position = new Vector3(X+x, 0.0f,-10f);
        }

        // 恣クリックされたら肝のセリフを燕幣
        if (Input.GetMouseButtonDown(0))
        {
            currentDialogueIndex++;
            // セリフをすべて燕幣した��栽、ダイアログを掲燕幣にする
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
        // セリフを燕幣
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    private void HideDialogue()
    {
        // ダイアログを掲燕幣にする�╂�えばテキストをクリアする��
        dialogueText.text = "";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

