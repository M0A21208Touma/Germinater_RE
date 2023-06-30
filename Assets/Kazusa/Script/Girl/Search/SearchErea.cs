using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchErea : MonoBehaviour
{
    private Player pl;
    public bool isEnemy;
    public bool isFlower;
    public Vector3 FlowerPosition { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        pl = FindObjectOfType<Player>();
        isEnemy = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isEnemy = true;
        }
        else if (other.gameObject.CompareTag ("Flower"))
        {
            isFlower= true;
            Vector3 flowerPosition = other.gameObject.transform.position;
            FlowerPosition = flowerPosition;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isEnemy= false;
        }
        else if (other.gameObject.CompareTag("Flower"))
        {
            isFlower = false;
        }
    }
}
