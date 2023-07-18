using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostFlower : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wind" || other.gameObject.tag == "Girl")
        {
            Destroy(this.gameObject);
        }
    }
}
