using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : StateMachineBehaviour
{
    public Transform playerget;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerget = GameObject.FindGameObjectWithTag("Player").transform;
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerget.position, 1*Time.deltaTime);
       // Debug.Log("Calling");
        Vector2 dist= (animator.transform.position - playerget.position);
       // Debug.Log("dist.x" + dist.x + "dist.y" + dist.y);
        Vector2 dir = dist.normalized;
        animator.transform.up = new Vector2(dir.x, dir.y);
        float dist2 = Vector2.Distance(animator.transform.position , playerget.position);
       // Debug.Log("dist2" + dist2 );
        if (dist2> 5)
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Walk", false);
        }

        if (dist2 < 1)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Attack", true);
           
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
