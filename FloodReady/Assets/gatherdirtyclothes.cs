using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatherdirtyclothes : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public CleaningChecklistCanvas checklist;

    void Update()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.ShowGatherClothesCanvas();
            checklistShown = true;
        }
    }
}
