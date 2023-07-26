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
        iLevel = SceneManager.GetActiveScene().buildIndex; 　　//変数iLevelに現在のLevelのindex番号を取り込みます
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene()                                // 次のシーンに進めるメソッドです
    {
        iLevel++;                                                       //　変数iLevelに1を足します
        SceneManager.LoadScene(iLevel);　　//　次のレベルシーンをロードします
    }
}
