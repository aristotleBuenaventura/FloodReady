using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTV : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public EvacuationChecklist checklist;

    void Start()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.Scene1ChecklistCanvas();
            checklistShown = true;
        }
    }
}
