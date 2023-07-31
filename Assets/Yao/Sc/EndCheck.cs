using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndCheck : MonoBehaviour
{
    public bool inEnd;
    private PoisonWave pw;
    private StopMove sm
        ;
    private void Start()
    {
        inEnd = false;
        pw = FindObjectOfType<PoisonWave>();
        sm = FindObjectOfType<StopMove>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Girl")
        {
            inEnd = true;
            sm.isStop = true;
          
            Debug.Log("ddd");
            pw.moveSpeed = 0.0f;
            SceneManager.LoadScene("Ending");

        }
    }
}
