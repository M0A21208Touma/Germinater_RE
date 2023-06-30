using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//　UnityのUIの機能を継承（使用）します
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI goalText;		//　Text型の変数goalTextを用意します	
    public TextMeshProUGUI gameOverText;        //　Text型の変数goalTextを用意します	
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
   
    public void GoalFlag()			//　他のクラスからアクセス可能なpublicのGaolFlag()というメソッドをつくりました　
    {
        goalText.gameObject.SetActive(true);        //　SetActiveをtrueにするだけのメソッドです	
        //inGame = false;
        // audioSource.PlayOneShot(sound03);
        Replay.SetActive(true);
        return;
    }

    public void GameOverFlag()			//　他のクラスからアクセス可能なpublicのGaolFlag()というメソッドをつくりました　
    {
        gameOverText.gameObject.SetActive(true);
        Replay.SetActive(true);
        //inGame = false;
        //audioSource.PlayOneShot(sound03);
        return;
    }
}
