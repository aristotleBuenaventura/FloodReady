using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPrybar : MonoBehaviour
{
    private bool checklistShown = false;
    public GameObject canvas;
    public CanvasToggle toggle;

    void Start()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            canvas.SetActive(true);
            checklistShown = true;
        }
    }
}
