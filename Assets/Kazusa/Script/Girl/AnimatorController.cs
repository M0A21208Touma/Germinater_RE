using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    private SearchErea se;
    private StopMove sm;
    private SpilitAction sa;
    private string walkStr = "isWalk";

    void Start()
    {
        animator = GetComponent<Animator>();
        sm = FindObjectOfType<StopMove>();
        se = FindObjectOfType<SearchErea>();
        sa = FindObjectOfType<SpilitAction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (se.isFlower || sa.isView && !sm.isStop)
        {
            animator.SetBool(walkStr, true);
        }
        else
        {
            animator.SetBool(walkStr, false);
        }
    }
}
