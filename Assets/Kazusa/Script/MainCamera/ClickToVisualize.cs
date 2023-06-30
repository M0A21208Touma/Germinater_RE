using UnityEngine;

public class ClickToVisualize : MonoBehaviour
{
    public GameObject spilit;
    //private GameObject spilit;
        // 現在生成されているオブジェクト
    public GameObject player;   //①移動させたいオブジェクト
    public int speed = 3;
    public GameObject magic_r;
    private Vector3 attackPoint;
    private GameObject clone;
    public GameObject Wind;
    private GameObject Windclone;
    // public float Magicspeed;
    public bool isView;
    public float delaySeconds = 3f;  // 破壊までの待機時間（秒）
    public Vector3 mouseWorldPos;

    void Start()
    {
        spilit = Instantiate(spilit, player.transform.position, Quaternion.identity);

        //Magicspeed = 10.0f;  // 弾の速度
        isView = false;

    }

    void Update()
    {
       if (Input.GetMouseButtonDown(1))  //右クリックでif分起動
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitInfo = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitInfo.collider.tag == "Ground")
            {
                Vector3 clickPoint = hitInfo.point;
                // 以前に生成されたオブジェクトがあれば削除する
                if (spilit != null)
                {
                    Destroy(spilit);
                }
                //clickPoint.z = 10.0f;  //②奥行を手前に来るように5.0fを指定。
                //Camera camera = Camera.main;  //②
                //touchWorldPosition = camera.ScreenToWorldPoint(clickPoint);  //②
                // 新しいオブジェクトを生成する
                spilit = Instantiate(spilit, clickPoint, Quaternion.identity);
                isView = false;
            }
            else if (hitInfo.collider.tag == "View")
            {
                Vector3 clickPoint = hitInfo.point;
                if (spilit != null)
                {
                    Destroy(spilit);
                }
                spilit = Instantiate(spilit, clickPoint, Quaternion.identity);
                isView = true;
            }
        }
           

        if (Input.GetMouseButtonDown(0)) //左クリック
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitInfo = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitInfo.collider.tag == "Ground" || hitInfo.collider.tag == "View")
            {
               attackPoint = hitInfo.point;
                // 弾（ゲームオブジェクト）の生成
                //attackPoint.z = 5.0f;//Magic_rの別のスクリプトを作る必要あり
                clone = Instantiate(magic_r, spilit.transform.position, Quaternion.identity);

                // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // 向きの生成（Z成分の除去と正規化）
                Vector3 shotForward = Vector3.Scale((mouseWorldPos - spilit.transform.position), new Vector3(1, 1, 0)).normalized;

                // 弾に速度を与える(要注意)
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
            }       
        }
        /*if (Vector3.Distance(clone.transform.position, mouseWorldPos) < 0.1f)
        {
            Debug.Log("aaa");
            Destroy(clone);
            Wind = Instantiate(Wind, mouseWorldPos, Quaternion.identity);
            Destroy(Wind, delaySeconds);
        }*/
        if (clone != null)
        {
            if (Vector3.Distance(attackPoint, clone.transform.position) < 0.1f)
            {
                clone.SetActive(false);
                Destroy(clone);
                Windclone = Instantiate(Wind, mouseWorldPos + new Vector3 (0,0,10), Quaternion.identity);
                Destroy(Windclone, delaySeconds);
            }
        }
        //player.transform.position = Vector3.MoveTowards(player.transform.position, spilit. transform.position, speed * Time.deltaTime); //playerオブジェクトが, 目的地に移動, 移動速度
    }
}

