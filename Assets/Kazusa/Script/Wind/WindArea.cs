using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float windForce = 10f; // ���̗�
    public float maxSpeed = 20f; // �ő呬�x
    public float minSpeed = 1f; // �ŏ����x�i���̑��x�ȉ��Œ�~�j

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
            rb.velocity = Vector2.zero; // �͈͊O�ɏo���瑬�x���[���ɂ���
        }
    }

    private void ApplyWindForce()
    {
        Vector2 direction = transform.position - GetNearestWindArea().transform.position;
        float distance = direction.magnitude;
        float speed = Mathf.Lerp(maxSpeed, minSpeed, distance / GetNearestWindArea().transform.localScale.x); // �����ɉ����đ��x����

        rb.AddForce(direction.normalized * windForce * speed * Time.deltaTime); // �͂�������
    }

    private void ApplySpeedDamping()
    {
        rb.velocity *= Mathf.Clamp01(1f - Time.deltaTime); // ���x�̌���

        if (rb.velocity.magnitude < minSpeed)
        {
            rb.velocity = Vector2.zero; // ���x�����ȉ��ɂȂ������~
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
