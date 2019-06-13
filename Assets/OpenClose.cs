using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    [SerializeField]
    GameObject open, closed;

    public void Open(bool isClosed)
    {
        if(isClosed)
        {
            open.SetActive(true);
            closed.SetActive(false);
            return;
        }
        open.SetActive(false);
        closed.SetActive(true);
    }
}
