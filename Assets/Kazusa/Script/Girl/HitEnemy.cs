using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    private Gamemanager gm;
    public GameObject Girl;
    private void Start()
    {
        gm = FindObjectOfType<Gamemanager>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gm.GameOverFlag();
            Debug.Log("fff");
            Destroy(Girl);
        }
    }
}
