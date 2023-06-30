using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalCheck : MonoBehaviour
{
    public bool inGoal;
    private PoisonWave pw;
    private StopMove sm
        ;
    private void Start()
    {
        inGoal = false;
        pw = FindObjectOfType<PoisonWave>();
        sm = FindObjectOfType<StopMove>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Girl")
        {
            inGoal = true;
            sm.isStop = true;
            Time.timeScale = 0f;
            Debug.Log("ddd");
            pw.moveSpeed = 0.0f;
        }
    }
}
