using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public static int speed;
    public GameObject player;   //①移動させたいオブジェクト
    //Vector3 touchWorldPosition;　//②マウスでタッチした箇所の座標を取得
    //public GameObject currentObject; // 現在生成されているオブジェクト
    //public GameObject pointObject;
    //private ClickToVisualize ctv;
    private StopMove sm;
    private SpilitAction sa ;
    private SearchErea se;
    public Transform targetObject; // 回転を固定する子オブジェクトのTransform
    private Quaternion initialRotation; // 初期の回転
    public GameObject odoroki;
    private bool isSee = false;
                                        //public GameObject PlayerView;
    /* [SerializeField]
     ClickToVisualize ctv;*/

    private void Start()
    {
        //ctv.spilit.transform.position = player.transform.position;
        //ctv = FindObjectOfType<ClickToVisualize>();
        sm = FindObjectOfType<StopMove>();
        sa = FindObjectOfType<SpilitAction>();
        se = FindObjectOfType<SearchErea>();
        // 初期の回転を保存
        initialRotation = targetObject.rotation;
        speed = 5;
        odoroki.SetActive(false);
    }


    void Update()
    {
        /*if (ctv.isView == true && sm.isStop == false)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, ctv.spilit.transform.position, speed * Time.deltaTime);
            Vector3 toDirection = ctv.spilit.transform.position - player.transform.position;
            // 対象物へ回転する
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);//playerオブジェクトが, 目的地に移動, 移動速度//playerオブジェクトが, 目的地に移動, 移動速度
        }*/
        if (se.isFlower == true)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, se.FlowerPosition, speed * Time.deltaTime);
            Vector3 toDirection = se.FlowerPosition - player.transform.position;
            // 対象物へ回転する
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);

            StartCoroutine(ActivateOdoroki());
            isSee = true;
        }
        else if (se.isEnemy == true)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, sa.mousePosition, speed * Time.deltaTime);
            Vector3 toDirection =  player.transform.position - sa.mousePosition;
            // 対象物へ回転する
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
            StartCoroutine(ActivateOdoroki());
            isSee = true;
        }
        else if (sa.isView == true && sm.isStop == false)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, sa.mousePosition, speed * Time.deltaTime);
            Vector3 toDirection = sa.mousePosition - player.transform.position;
            // 対象物へ回転する
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);

            isSee = false;
        }
        else
        {

        }
        /*else
        {
            Vector3 toDirection = sa.mousePosition - player.transform.position;
            // 対象物へ回転する
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);//playerオブジェクトが, 目的地に移動, 移動速度//playerオブジェクトが, 目的地に移動, 移動速度
        }*/
    }
    private void LateUpdate()
    {
        // 子オブジェクトの回転を初期の回転に設定
        targetObject.rotation = initialRotation;
    }
    private IEnumerator ActivateOdoroki()
    {
        if (isSee == false)
        {
            odoroki.SetActive(true);  // odorokiをアクティブにする

            yield return new WaitForSeconds(1f);  // 1秒待つ

            odoroki.SetActive(false);  // odorokiを非アクティブにする
        }
     }
}