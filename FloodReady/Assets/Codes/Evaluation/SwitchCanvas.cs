using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCanvas : MonoBehaviour
{
    public GameObject[] canvas;
    int index;

    void Start()
    {
        index = 0;
        UpdateCanvas();
    }

    void UpdateCanvas()
    {
        for (int i = 0; i < canvas.Length; i++)
        {
            if (i == index)
            {
                canvas[i].SetActive(true);
            }
            else
            {
                canvas[i].SetActive(false);
            }
        }
    }

    public void Next()
    {
        index += 1;
        if (index >= canvas.Length)
        {
            index = 0;
        }
        UpdateCanvas();
        Debug.Log(index);
    }

    public void Previous()
    {
        index -= 1;
        if (index < 0)
        {
            index = canvas.Length - 1;
        }
        UpdateCanvas();
        Debug.Log(index);
    }
}
