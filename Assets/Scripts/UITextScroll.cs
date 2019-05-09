using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITextScroll : MonoBehaviour
{
    RectTransform container;
    float width;
    float anchorX;
    float incWidth = 0;
    float incAnchorX = 0;


    void Awake()
    {
        container = GetComponent<RectTransform>();

        width = container.sizeDelta.y;
        anchorX = container.anchoredPosition.x;

        Debug.Log(width);
    }

    void Update()
    {
        container.sizeDelta = new Vector2(container.sizeDelta.x, 0);
        container.anchoredPosition = new Vector2(0, container.anchoredPosition.y);
        if (container.sizeDelta.y < width)
        {
            container.sizeDelta = new Vector2(container.sizeDelta.x, incWidth++);
        }
        if (container.anchoredPosition.x < anchorX)
        {
            container.anchoredPosition = new Vector2(incAnchorX++, container.anchoredPosition.y);
        }

    }
}
