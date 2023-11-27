using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBreakerCanvas : MonoBehaviour
{
    public bool Fan;
    public bool TV;
    public CanvasController BreakerCanvas;

    void Start()
    {
        Fan = false;
        TV = false;
    }

    void UpdateBreakerCanvas()
    {
        if (Fan && TV)
        {
            BreakerCanvas.ShowTurnOffBreakerCanvas();
        }
    }

    public void SetBooleanFan(bool value)
    {
        Fan = value;
        UpdateBreakerCanvas();
    }

    public void SetBooleanTV(bool value)
    {
        TV = value;
        UpdateBreakerCanvas();
    }
}
