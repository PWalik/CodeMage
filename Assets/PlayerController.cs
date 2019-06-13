using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Move nextMove;
    bool isPlayer;
    AI playerAI;
    int currentGolem;
    int hp;
    public int CurrentGolem { get => currentGolem; }

    private void Start()
    {
        playerAI = new AI();
    }

    public Move DecideOnMove()
    {
        if(!isPlayer)
        {
            return AIGetMove();
        }
        return Move.nothing;
    }

    Move AIGetMove()
    {
        return playerAI.AIMove();
    }
}
