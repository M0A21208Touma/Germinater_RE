using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float windForce = 10f; // 風の力
    public float maxSpeed = 20f; // 最大速度
    public float minSpeed = 1f; // 最小速度（この速度以下で停止）

    private bool isInWindArea = false;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isInWindArea)
        {
            ApplyWindForce();
            ApplySpeedDamping();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wind"))
        {
            isInWindArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wind"))
        {
            isInWindArea = false;
            rb.velocity = Vector2.zero; // 範囲外に出たら速度をゼロにする
        }
    }

    private void ApplyWindForce()
    {
        Vector2 direction = transform.position - GetNearestWindArea().transform.position;
        float distance = direction.magnitude;
        float speed = Mathf.Lerp(maxSpeed, minSpeed, distance / GetNearestWindArea().transform.localScale.x); // 距離に応じて速度を補間

        rb.AddForce(direction.normalized * windForce * speed * Time.deltaTime); // 力を加える
    }

    private void ApplySpeedDamping()
    {
        rb.velocity *= Mathf.Clamp01(1f - Time.deltaTime); // 速度の減衰

        if (rb.velocity.magnitude < minSpeed)
        {
            rb.velocity = Vector2.zero; // 速度が一定以下になったら停止
        }
    }

    private GameObject GetNearestWindArea()
    {
        GameObject[] windAreas = GameObject.FindGameObjectsWithTag("Wind");
        float nearestDistance = Mathf.Infinity;
        GameObject nearestWindArea = null;

        foreach (GameObject windArea in windAreas)
        {
            float distance = Vector2.Distance(transform.position, windArea.transform.position);
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestWindArea = windArea;
            }
        }

        return nearestWindArea;
    }
}
