using UnityEngine;

public class WindZone : MonoBehaviour
{
    public float windForce = 10f;           // 風の力
    public float windDeceleration = 1f;     // 速度減少率
    public float minSpeed = 1f;             // 飛ばなくなる速度の閾値

    private bool isInWindZone = false;      // オブジェクトAがWindタグを持つオブジェクトBの範囲内にいるかどうか
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
                // 速度が一定以下になったら飛ばなくなる
                rb.velocity = Vector2.zero;
            }*/
        }
        else
        {
            rb.velocity *= (1f - windDeceleration * Time.fixedDeltaTime);

            if (rb.velocity.magnitude < minSpeed)
            {
                // 速度が一定以下になったら飛ばなくなる
                rb.velocity = Vector2.zero;
            }
        }
    }
}