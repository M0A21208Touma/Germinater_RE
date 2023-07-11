using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpilitAction : MonoBehaviour
{
    private Camera mainCamera;
    public bool isView;
    public Vector3 mousePosition;
    //public bool isAttack;
    public int count;
    public Vector3 currentPosition;
    public int attackspeed = 5;
    public GameObject magic_g;
    //public GameObject Wind;
    public GameObject Girl;
    public float delaySeconds = 3f;
    //public GameObject followSp;
    //public GameObject AttackSp;
    public float rapidTime;	//      毎フレーム時間から引いていく数
    public float rapid;                                 //　ボールを出せるようになるまでの時間　float型の変数を用意します
    public float oriRapid;                         //　元のrapidに入れられていた値を格納しておく変数　 float型の変数を用意

    private List<Vector3> attackPoints = new List<Vector3>();  // クリックした位置を保存する配列
    private List<GameObject> clones = new List<GameObject>();  // 生成した球を保存する配列
    private List<GameObject> windClones = new List<GameObject>();  // 生成したWindオブジェクトを保存する配列
    public static bool isShoot;

    private void Start()
    {
        mainCamera = Camera.main;
        isView = false;
        //isAttack = false;
        count = 0;
        //followSp.SetActive(false);
        //AttackSp.SetActive(false);
        oriRapid = rapid;             //editorでrapidに入れた値をoriRapidに格納します
        isShoot = false;
    }

    private void Update()
    {
        mousePosition = GetMouseWorldPosition();
        oriRapid -= rapidTime;                                   //変数oriRapidから変数rapidTimeの値を引いて、また変数oriRapidに戻します
        //妖精の動き
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        //currentPosition = transform.position;

        //風の球射出
        if (Input.GetMouseButtonDown(0))  // 左クリック
        {
            //transform.position = currentPosition;
            //attackPoints.Add(mousePosition);  // クリックした位置を配列に追加
            if (oriRapid <= 0.0f == true)     //もしrapidの値が０以下になったら、マウスボタンを押した時に弾が出るようになります
            {
                GameObject clone = Instantiate(magic_g, this.transform.position, Quaternion.identity);
                //clones.Add(clone);  // 生成した球を配列に追加

                // 向きの生成（Z成分の除去と正規化）
                Vector3 shotForward = Vector3.Scale((mousePosition - Girl.transform.position), new Vector3(1, 1, 0)).normalized;

                // 弾に速度を与える
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * attackspeed;
                oriRapid = rapid;               //　 rapidに元の値を入れて戻します　

                // 2秒後にcloneを削除する
                Destroy(clone, 2f);
                isShoot = true;
            }
        }
       
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Start")
        {
            Time.timeScale = 1f;
            Debug.Log("ddd");
        }
        else if (other.gameObject.tag == "View")
        {
            isView = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "View")
        {
            isView = false;
        }
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}
