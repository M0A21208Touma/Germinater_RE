using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindInpact : MonoBehaviour
{
    public float forceMagnitude = 10f; // êÅÇ´îÚÇŒÇ∑óÕÇÃëÂÇ´Ç≥
    public float forceReductionRate = 0.9f; // óÕÇÃå∏êäó¶

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Box")|| other.CompareTag("Enemy"))
        {
            Rigidbody2D enemyRb = other.GetComponent<Rigidbody2D>();
            if (enemyRb != null)
            {
                Vector2 direction = other.transform.position - transform.position;
                Vector2 force = direction.normalized * forceMagnitude;
                enemyRb.AddForce(force, ForceMode2D.Impulse);
            }
        }
        if (other.CompareTag("Flower"))
        {
            Destroy(other.gameObject);
        }
    }

    /*private void FixedUpdate()
    {
        // óÕÇÃå∏êä
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, GetComponent<CircleCollider2D>().radius);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Box") || collider.CompareTag("Enemy"))
            {
                Rigidbody2D enemyRb = collider.GetComponent<Rigidbody2D>();
                if (enemyRb != null)
                {
                    enemyRb.velocity *= forceReductionRate;
                }
            }
        }
    }*/
}
