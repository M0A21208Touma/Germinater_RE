using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostFlower : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wind")
        {
            Destroy(this.gameObject);
        }
    }
}
