using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//�@Unity��UI�̋@�\���p���i�g�p�j���܂�
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI goalText;		//�@Text�^�̕ϐ�goalText��p�ӂ��܂�	
    public TextMeshProUGUI gameOverText;        //�@Text�^�̕ϐ�goalText��p�ӂ��܂�	
    public GameObject Replay;
   private GoalCheck gc;
    private StopMove sm;
    private PoisonWave pw;
                                     // Start is called before the first frame update


    void Start()
    {
        gc = FindObjectOfType<GoalCheck>();
        sm = FindObjectOfType<StopMove>();
        pw = FindObjectOfType<PoisonWave>();
        goalText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        Time.timeScale = 0.0f;
        Replay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gc.inGoal == true)
        {
            GoalFlag();
            sm.isStop = true;
        }
        if (pw.inGameOver == true)
        {
          GameOverFlag();
        }
    }
   
    public void GoalFlag()			//�@���̃N���X����A�N�Z�X�\��public��GaolFlag()�Ƃ������\�b�h������܂����@
    {
        goalText.gameObject.SetActive(true);        //�@SetActive��true�ɂ��邾���̃��\�b�h�ł�	
        //inGame = false;
        // audioSource.PlayOneShot(sound03);
        Replay.SetActive(true);
        return;
    }

    public void GameOverFlag()			//�@���̃N���X����A�N�Z�X�\��public��GaolFlag()�Ƃ������\�b�h������܂����@
    {
        gameOverText.gameObject.SetActive(true);
        Replay.SetActive(true);
        //inGame = false;
        //audioSource.PlayOneShot(sound03);
        return;
    }
}