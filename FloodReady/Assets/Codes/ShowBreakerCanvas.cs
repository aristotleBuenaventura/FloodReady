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

    public void SetBooleanFan(bool value)
    {
        Fan = value;
    }

    public void SetBooleanTV(bool value)
    {
        TV = value;
    }

    void Update()
    {
        if(Fan == true && TV == true)
        {
            BreakerCanvas.ShowTurnOffBreakerCanvas();
        }
    }
}
