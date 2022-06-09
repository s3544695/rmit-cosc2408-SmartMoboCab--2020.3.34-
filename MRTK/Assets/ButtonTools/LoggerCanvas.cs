using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoggerCanvas : MonoBehaviour
{
    [SerializeField] private Text topLeftText;
    [SerializeField] private Text topRightText;
    [SerializeField] private Text bottomLeftText;
    [SerializeField] private Text bottomRightText;

    private float prevHeight = 0;
    public void Hide(RectTransform panel)
    {
        if (panel.sizeDelta.y == 0)
        {
            panel.sizeDelta = new Vector2(panel.sizeDelta.x, prevHeight);
        }
        else
        {
            prevHeight = panel.sizeDelta.y;
            panel.sizeDelta = new Vector2(panel.sizeDelta.x, 0);
        }
    }

    public void LogTopLeft(string text)
    {
        topLeftText.text = text;
    }

    public void LogBottomLeft(string text)
    {
        bottomLeftText.text = text;
    }

    public void LogTopRight(string text)
    {
        topRightText.text = text;
    }

    public void LogBottomRight(string text)
    {
        bottomRightText.text = text;
    }

}
