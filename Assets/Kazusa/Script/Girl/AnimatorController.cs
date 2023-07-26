using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    private SearchErea se;
    private StopMove sm;
    private SpilitAction sa;
    private string walkR = "isWalk_R";
    private string walkL = "isWalk_L";
    private string walkF = "isWalk_F";
    private string walkB = "isWalk_B";
    private string stopR = "isStop_R";
    private string stopL = "isStop_L";
    private string stopF = "isStop_F";
    private string stopB = "isStop_B";

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
            if (LostFlower.inTouch)
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
             else if ((PositionCheck.angle > 0 && PositionCheck.angle <= 60) || (PositionCheck.angle >= -60 && PositionCheck.angle <= 0))
            {
                animator.SetBool(walkR, true);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
            else if ((PositionCheck.angle >= 120 && PositionCheck.angle <= 180) || (PositionCheck.angle > -180 && PositionCheck.angle <= -120))
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, true);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
                Debug.Log("fff");
            }
            else if (PositionCheck.angle > -120 && PositionCheck.angle < -60)
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, true);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
            else if (PositionCheck.angle > 60 && PositionCheck.angle < 120)
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, true);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
        }
        else
        {
            if ((PositionCheck.angle > 0 && PositionCheck.angle <= 60) || (PositionCheck.angle >= -60 && PositionCheck.angle <= 0))
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, true);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
            else if ((PositionCheck.angle >= 120 && PositionCheck.angle <= 180) || (PositionCheck.angle > -180 && PositionCheck.angle <= -120))
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, true);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, false);
            }
            else if (PositionCheck.angle > -120 && PositionCheck.angle < -60)
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, true);
                animator.SetBool(stopB, false);
            }
            else if (PositionCheck.angle > 60 && PositionCheck.angle < 120)
            {
                animator.SetBool(walkR, false);
                animator.SetBool(walkL, false);
                animator.SetBool(walkF, false);
                animator.SetBool(walkB, false);
                animator.SetBool(stopR, false);
                animator.SetBool(stopL, false);
                animator.SetBool(stopF, false);
                animator.SetBool(stopB, true);
            }
        }
    }
}
