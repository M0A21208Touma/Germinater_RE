using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boarAnime : MonoBehaviour
{
    private Animator animator;
    private string moveB = "isMove_B";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy_move_2.isMove == true)
        {
            animator.SetBool(moveB, true);
            Debug.Log("222");
        }
        else if(enemy_move_2.isMove == false)
        {
            animator.SetBool(moveB, false);
        }
    }
}
