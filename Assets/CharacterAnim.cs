using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash, isJampHash;
   
    void Start()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJampHash = Animator.StringToHash("isJamp");
    }

   
    void Update()
    {
       bool isRunning = animator.GetBool("isRunning");
       bool isWalking = animator.GetBool("isWalking");
       bool isJamp = animator.GetBool("isJamp");
       bool forwardPressend = Input.GetKey(KeyCode.W);
       bool Run = Input.GetKey(KeyCode.LeftShift);



       if (!isWalking && forwardPressend)
       {
            animator.SetBool("isWalking",true);
       }

       if (isWalking && !forwardPressend)
       {
            animator.SetBool("isWalking",false);
       }

       if (!isRunning && (forwardPressend && Run))
       {
            animator.SetBool("isRunning",true);
       }

       if (isRunning && (!forwardPressend || !Run))
       {
            animator.SetBool("isRunning",false);
       }

    }
}
