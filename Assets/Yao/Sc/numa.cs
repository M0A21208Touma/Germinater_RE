using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Girl")
        {
            Player.speed = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Girl")
        {
            Player.speed = 5;
        }
    }
}