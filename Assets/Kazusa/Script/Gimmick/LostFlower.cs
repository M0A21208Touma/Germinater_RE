using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostFlower : MonoBehaviour
{
    private SearchErea se;
    public GameObject Flower;
    public GameObject HikariFlower;
    public static bool inTouch;


    private void Start()
    {
        se = FindObjectOfType<SearchErea>();
        Flower.SetActive(true);
        HikariFlower.SetActive(false);
        inTouch = false;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wind")
        { 
            Destroy(this.gameObject);
            Debug.Log("fff");

        }
        if (other.gameObject.tag == "Girl")
        {
            inTouch = true;
        }
        if (other.gameObject.tag == "Search")
        {
            Flower.SetActive(false);
            HikariFlower.SetActive(true);
        }
    }
}
