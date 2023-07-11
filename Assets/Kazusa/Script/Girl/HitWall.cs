using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour
{
    public GameObject Eria1;
    public GameObject Eria2;
    public GameObject Eria3;
    public GameObject Eria4;
    public GameObject Eria5;
    public GameObject Eria6;
    public GameObject Eria7;
    public GameObject Eria8;
    public GameObject Eria9;
    public GameObject Eria10;
    static public bool isEnemy;
    //static public bool isFlower;
    public Vector3 FlowerPosition { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        Eria1.SetActive(true);
        Eria2.SetActive(true);
        Eria3.SetActive(true);
        Eria4.SetActive(true);
        Eria5.SetActive(true);
        Eria6.SetActive(true);
        Eria7.SetActive(true);
        Eria8.SetActive(true);
        Eria9.SetActive(true);
        Eria10.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        /*if (Input.GetMouseButtonDown(1))
        {
            Eria1.SetActive(true);
            Eria2.SetActive(true);
            Eria3.SetActive(true);
            Eria4.SetActive(true);
            Eria5.SetActive(true);
            Eria6.SetActive(true);
            Eria7.SetActive(true);
            Eria8.SetActive(true);
            Eria9.SetActive(true);
            Eria10.SetActive(true);
        }*/
     }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Eria1.SetActive(false);
            Eria2.SetActive(false);
            Eria3.SetActive(false);
            Eria4.SetActive(false);
            Eria5.SetActive(false);
            Eria6.SetActive(false);
            Eria7.SetActive(false);
            Eria8.SetActive(false);
            Eria9.SetActive(false);
            Eria10.SetActive(false);
        }
        /*if (other.gameObject.CompareTag("Enemy"))
        {
            isEnemy = true;
            Debug.Log("aaa");
        }*/
        if (other.gameObject.CompareTag("Flower"))
        {
            //isFlower = true;
            Vector3 flowerPosition = other.gameObject.transform.position;
            FlowerPosition = flowerPosition;
            //Debug.Log(isFlower);  
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Eria1.SetActive(true);
            Eria2.SetActive(true);
            Eria3.SetActive(true);
            Eria4.SetActive(true);
            Eria5.SetActive(true);
            Eria6.SetActive(true);
            Eria7.SetActive(true);
            Eria8.SetActive(true);
            Eria9.SetActive(true);
            Eria10.SetActive(true);
        }
    }
}
