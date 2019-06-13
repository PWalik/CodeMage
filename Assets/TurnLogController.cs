using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnLogController : MonoBehaviour
{
    [SerializeField]
    GameObject logMsg;
    [SerializeField]
    Transform logHolder;
    public void AddNewMessage(string message)
    {
        GameObject obj = Instantiate(logMsg, logHolder);
        logMsg.GetComponent<Text>().text = message;
    }
}
