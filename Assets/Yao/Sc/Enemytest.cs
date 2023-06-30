using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytest : MonoBehaviour
{
    private GameObject enemy ;  //①動かしたいオブジェクトをインスペクターから入れる。
    public int Espeed = 5;  //オブジェクトが自動で動くスピード調整
    Vector3 movePosition;  //②オブジェクトの目的地を保存
    public int targetx1;
    public int targety1;
    public int targetx2;
    public int targety2;

    void Start()
    {
        movePosition = MoveRandomPosition();  //②実行時、オブジェクトの目的地を設定
        enemy = this.gameObject;
    }

    void Update()
    {
        if (movePosition == enemy.transform.position)  //②playerオブジェクトが目的地に到達すると、
        {
            movePosition = MoveRandomPosition();  //②目的地を再設定
        }
        this.enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, Espeed * Time.deltaTime);  //①②playerオブジェクトが, 目的地に移動, 移動速度
    }

    private Vector3 MoveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 randomPosi = new Vector3(Random.Range(targetx1, targetx2), Random.Range(targety1, targety2), 0);
        return randomPosi;
    }
}

