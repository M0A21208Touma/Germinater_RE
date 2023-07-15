using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "kiri" || other.gameObject.tag == "Kawa")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Kawa")
        {
            Destroy(gameObject);
        }
    }
}
