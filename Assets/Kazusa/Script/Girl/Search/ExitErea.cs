using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitErea : MonoBehaviour
{
    private SearchErea se;
    // Start is called before the first frame update
    static public bool isEnemy;
    static public bool isFlower;
    public Vector3 FlowerPosition { get; private set; }
    void Start()
    {
        se = FindObjectOfType<SearchErea>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        /*if (other.gameObject.CompareTag("Enemy"))
        {
            SearchErea. isEnemy= false;
        }
        else if (other.gameObject.CompareTag("Flower"))
        {
            SearchErea.isFlower = false;
        }*/
    }
 }
