using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    Transform tf; //Main CameraのTransform
    private float x = 21.2f;
    public Text dialogueText; // セリフを表示するテキストUI
    public string[] dialogues; // セリフの配列
    private int currentDialogueIndex = 0; // 現在表示しているセリフのインデックス
    public Text Openingtext;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを取得する。                                                     
        ShowDialogue(); // 最初のセリフを表示
    }

    // Update is called once per frame
    void Update()
    {
         float X= this.gameObject.GetComponent<Transform>().position.x;
        if (Input.GetMouseButtonDown(0))
        {
            tf.position = new Vector3(X+x, 0.0f,-10f);
        }

        // 左クリックされたら次のセリフを表示
        if (Input.GetMouseButtonDown(0))
        {
            currentDialogueIndex++;
            // セリフをすべて表示した場合、ダイアログを非表示にする
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
        // セリフを表示
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    private void HideDialogue()
    {
        // ダイアログを非表示にする（例えばテキストをクリアする）
        dialogueText.text = "";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

