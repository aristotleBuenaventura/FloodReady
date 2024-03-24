using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closevalve : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public CleaningChecklistCanvas checklist;

    void Update()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.ShowOverall();
            checklistShown = true;
        }
    }
}
