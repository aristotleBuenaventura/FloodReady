using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAWindow : MonoBehaviour
{
    private bool checklistShown = false;
    public GameObject canvas;
    public CanvasToggle toggle;
    public GameObject CallingHelp;

    void Start()
    {
        if (!checklistShown)
        {
            CallingHelp.SetActive(true);
            toggle.showChecklist();
            canvas.SetActive(true);
            checklistShown = true;
        }
    }
}
