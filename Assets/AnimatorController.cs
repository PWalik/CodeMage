using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    void Update()
    {
        
    }

    public void PlayerTurn(bool isPlayerOne)
    {
        if(isPlayerOne)
        {
            anim.SetBool("PlayerOneTurn", true);
            anim.SetBool("PlayerTwoTurn", false);
        }
        else
        {
            anim.SetBool("PlayerTwoTurn", true);
            anim.SetBool("PlayerOneTurn", false);
        }
    }

    public void AttackAnim()
    {
        anim.SetBool("PlayerOneTurn", false);
        anim.SetBool("PlayerTwoTurn", false);
    }
}
