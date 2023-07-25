using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchErea : MonoBehaviour
{
    private Player pl;
    public bool isEnemy;
    public bool isFlower;
    public static bool isEnemyS;
    public static bool isFlowerS;
    public static float SoundCount;
    public Vector3 FlowerPosition { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        pl = FindObjectOfType<Player>();
        isEnemy = false;
        isFlower = false;
        isEnemyS = false;
        isEnemyS = false;
        SoundCount = 0;
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
            isEnemyS = true;
            SoundCount++;
        }
        else if (other.gameObject.CompareTag ("Flower"))
        {
            isFlower= true;
            Vector3 flowerPosition = other.gameObject.transform.position;
            FlowerPosition = flowerPosition;
            isFlowerS = true;
            SoundCount++;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isEnemy= false;
            SoundCount =0;
        }
        else if (other.gameObject.CompareTag("Flower"))
        {
            isFlower = false;
            LostFlower.inTouch = false;
            SoundCount = 0;
        }
    }
}
