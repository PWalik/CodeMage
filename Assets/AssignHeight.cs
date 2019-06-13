using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AssignHeight : MonoBehaviour
{
    public float textHeight;
    int numberOfChildren;

    void Update()
    {
        if(numberOfChildren != transform.childCount)
        {
            numberOfChildren = transform.childCount;
            GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, textHeight * numberOfChildren);
        }
    }
}
