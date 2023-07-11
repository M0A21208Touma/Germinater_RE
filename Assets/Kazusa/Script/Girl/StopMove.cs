using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMove : MonoBehaviour
{
    public bool isStop;
    public bool isFlower;
    private SpilitAction sa;
    private SearchErea se;
    // Start is called before the first frame update
    void Start()
    {
        isStop = false;
        isFlower = false;
        sa = FindObjectOfType<SpilitAction>();
        se = FindObjectOfType<SearchErea>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(1))//右クリック
        {
            isStop = false;
        }*/
        if (isFlower == true || se.isEnemy==true)
        {
            isStop = true;
        }
        else if ((/*sa.isAttack == false&&*/  isFlower == false)&& se.isEnemy == false)
        {
            isStop = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Flower"))
        {
            isFlower = true;
            isStop = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Flower"))
        {
            isFlower = false;
            isStop = false;
        }
    }
}
