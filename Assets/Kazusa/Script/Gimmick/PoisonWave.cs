using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonWave : MonoBehaviour
{
    private Transform oriPos;
    public float moveSpeed = 5f; // ˆÚ“®‘¬“x
    public bool inGameOver;
    public GameObject Girl;
    private Gamemanager gm;

    void Start()
    {
        oriPos = transform;
        gm = FindObjectOfType<Gamemanager>();
        //inGameOver = false;
    }

    void Update()
    {
        float moveAmount = moveSpeed * Time.deltaTime;
        transform.Translate(moveAmount, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Girl")
        {
            gm.GameOverFlag();
            Destroy(Girl);
            //inGameOver = true;
        }
    }
}
