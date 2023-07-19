using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float windForce = 10f;           // ���̗�
    public float windDeceleration = 1f;     // ���x������
    public float minSpeed = 1f;             // ��΂Ȃ��Ȃ鑬�x��臒l

    private bool isInWindZone = false;      // �I�u�W�F�N�gA��Wind�^�O�����I�u�W�F�N�gB�͈͓̔��ɂ��邩�ǂ���
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Wind"))
        {
            isInWindZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Wind"))
        {
            isInWindZone = false;
        }
    }

    private void FixedUpdate()
    {
        if (isInWindZone && rb.velocity == Vector2.zero)
        {
            Vector2 windDirection = transform.position - GameObject.FindGameObjectWithTag("Girl").transform.position;
            rb.AddForce(windDirection.normalized * windForce, ForceMode2D.Force);
            //rb.velocity *= (1f - windDeceleration * Time.fixedDeltaTime);
            isInWindZone = false;
            /*if (rb.velocity.magnitude < minSpeed)
            {
                // ���x�����ȉ��ɂȂ������΂Ȃ��Ȃ�
                rb.velocity = Vector2.zero;
            }*/
        }
        else
        {
            rb.velocity *= (1f - windDeceleration * Time.fixedDeltaTime);

            if (rb.velocity.magnitude < minSpeed)
            {
                // ���x�����ȉ��ɂȂ������΂Ȃ��Ȃ�
                rb.velocity = Vector2.zero;
            }
        }
    }
}