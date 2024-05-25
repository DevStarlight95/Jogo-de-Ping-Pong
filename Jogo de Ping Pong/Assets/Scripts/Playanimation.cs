using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playanimation : MonoBehaviour
{
 
    public Animator animator;

    public void Player() 
    {
        animator.SetTrigger("Play");
    }
}
