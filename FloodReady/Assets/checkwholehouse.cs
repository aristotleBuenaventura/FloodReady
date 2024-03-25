using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkwholehouse : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public CleaningChecklistCanvas checklist;

    void Start()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.ShowOverall();
            checklistShown = true;
        }
    }
}
