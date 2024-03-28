using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gobag : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public EvacuationChecklist checklist;

    void Start()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.HowToPrepareGoBagCanvas();
            checklistShown = true;
        }
    }
}
