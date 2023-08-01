using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    Transform tf; //Main Camera§ŒTransform
    private float x = 21.2f;
    public Text dialogueText; // •ª•ÅE’§Ú±˙Êæ§π§ÅE∆•≠•π•»UI
    public string[] dialogues; // •ª•ÅE’§Œ≈‰¡–
    private int currentDialogueIndex = 0; // ¨F‘⁄±˙Êæ§∑§∆§§§ÅEª•ÅE’§Œ•§•Û•«•√•Ø•π
    public Text Openingtext;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main Camera§ŒTransform§Ú»°µ√§π§ÅE£                                                     
        ShowDialogue(); // ◊˚œı§Œ•ª•ÅE’§Ú±˙Êæ
    }

    // Update is called once per frame
    void Update()
    {
         float X= this.gameObject.GetComponent<Transform>().position.x;
        if (Input.GetMouseButtonDown(0))
        {
            tf.position = new Vector3(X+x, 0.0f,-10f);
        }

        // ◊Û•Ø•ÅE√•Ø§µ§ÅEø§È¥Œ§Œ•ª•ÅE’§Ú±˙Êæ
        if (Input.GetMouseButtonDown(0))
        {
            currentDialogueIndex++;
            // •ª•ÅE’§Ú§π§Ÿ§∆±˙Êæ§∑§øàˆ∫œ°¢•¿•§•¢•˙¡∞§Ú∑«±˙Êæ§À§π§ÅE
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
        // •ª•ÅE’§Ú±˙Êæ
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    private void HideDialogue()
    {
        // •¿•§•¢•˙¡∞§Ú∑«±˙Êæ§À§π§ÅE®¿˝§®§–•∆•≠•π•»§Ú•Ø•ÅE¢§π§ÅE©
        dialogueText.text = "";
    }

    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

