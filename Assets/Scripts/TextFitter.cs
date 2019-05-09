using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextFitter : MonoBehaviour
{

    Text text;
    RectTransform container;

    void Awake()
    {
        text = GetComponent<Text>();
        container = GetComponent<RectTransform>();

        float nbLigne = 0;
        float size = text.fontSize;
        float length = (float)text.text.Length;
        float space = text.lineSpacing;
        // float width = scrollView.GetComponent<RectTransform>().sizeDelta.x;
        float widthParent = transform.parent.parent.GetComponent<RectTransform>().sizeDelta.x;
        float heightParent = transform.parent.parent.GetComponent<RectTransform>().sizeDelta.y;
        float height = container.sizeDelta.y;
        Debug.Log(" size: " + size);
        Debug.Log(" length: " + length);
        Debug.Log(" space: " + space);
        Debug.Log(" width: " + widthParent);


        // float nbLigne = size * length / widthParent;
        // Debug.Log(" nbLigne: " + nbLigne);
        // height = nbLigne * size;
        // Debug.Log(" height: " + height);
        // container.sizeDelta = new Vector2(container.sizeDelta.x, height);

        nbLigne = text.text.Split('\n').Length + 1;


        float oneLigne = 0;
        for (int i = 0; i < length; i++)
        {

            string str = text.text.Substring(i, 1);
            oneLigne += size;

            if (str == "\n")
            {
                oneLigne = 0;
            }
            else if (oneLigne >= widthParent)
            {
                nbLigne++;
                oneLigne = 0;
            }
        }
        Debug.Log(" nbLigne: " + nbLigne);

    }


}
