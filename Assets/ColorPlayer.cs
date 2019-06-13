using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColorPlayer : MonoBehaviour
{
    public Color[] col;
    public SpriteRenderer playerToCol1, playerToCol2;


    public void ColorThePlayer(int colorNumber)
    {
        playerToCol1.color = col[colorNumber];
    }

    public void ColorThePlayer(int colorNumber, bool isPlayerOne)
    {
        if(isPlayerOne) playerToCol1.color = col[colorNumber];
        else playerToCol2.color = col[colorNumber];
    }
}
