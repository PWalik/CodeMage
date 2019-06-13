using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Move {nothing, ability1, ability2, ability3, ability4, swap1, swap2, swap3, pass };
public class TurnHandler : MonoBehaviour
{
    [SerializeField]
    PlayerController player1, player2;
    [SerializeField]
    AnimatorController anim;
    [SerializeField]
    UIController ui;
    [SerializeField]
    ColorPlayer colorPlayer;
    [SerializeField]
    TurnLogController turnLog;
    int turn = 1;
    bool isPlayerOne = true;
    bool isTurnDone = false;
    bool isAnimDone = false;

    void Start()
    {
        GameStart();
    }

    void GameStart()
    {
        turn = 1;
        isPlayerOne = true;
        ui.ChangeUI(isPlayerOne, player1.CurrentGolem);
        anim.PlayerTurn(isPlayerOne);
    }


    public void PlayerChangeForm(int form)
    {
        colorPlayer.ColorThePlayer(form, isPlayerOne);
        NewLogMessage(GetMoveFromInt(form, true), true, 0, false);
        NextTurn();
    }


    void NextTurn()
    {

        isPlayerOne = !isPlayerOne;
        turn++;
        ui.ChangeUI(isPlayerOne, isPlayerOne? player1.CurrentGolem: player2.CurrentGolem);
        anim.PlayerTurn(isPlayerOne);
    }


    public void ExecuteMove(int moveNumber)
    {
        int dmg = Random.Range(30, 150);
        NewLogMessage(GetMoveFromInt(moveNumber, false), false, dmg, dmg > 100? true: false);
        NextTurn();
    }

    public Move GetMoveFromInt(int moveNumber, bool isTransform)
    {
        switch(moveNumber)
        {
            case 0:
                if (isTransform) return Move.swap1;
                else return Move.ability1;
            case 1:
                if (isTransform) return Move.swap2;
                else return Move.ability2;
            case 2:
                if (isTransform) return Move.swap3;
                else return Move.ability3;
            case 3:
                if (!isTransform) return Move.ability4;
                break;
        }
        return Move.nothing;
    }




    void NewLogMessage(Move move, bool isTransform, int damage, bool isCrit)
    {
        string message = "Turn " + turn + ": ";
        if(isTransform)
        {
            message += "Player " + (isPlayerOne ? "1" : "2") + " transformed into ";
            switch(move)
            {
                case Move.swap1:
                    message += "a fire golem!";
                    break;
                case Move.swap2:
                    message += "an ice golem!";
                    break;
                case Move.swap3:
                    message += "an earth golem!";
                    break;
            }
        }
        else
        {
            message += "Player " + (isPlayerOne ? "1" : "2") + " used ";
                switch(move)
            {
                case Move.ability1:
                    message += "Ability1";
                        break;
                case Move.ability2:
                    message += "Ability2";
                        break;
                case Move.ability3:
                    message += "Ability3";
                        break;
                case Move.ability4:
                    message += "Ability4";
                    break;
            }
            message += " on Player " + (isPlayerOne ? "2" : "1") + " dealing " + damage + " damage!";
            if (isCrit) message += " Critical Strike!";
        }

        turnLog.AddNewMessage(message);
    }


}
