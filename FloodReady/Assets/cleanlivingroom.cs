using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanlivingroom : MonoBehaviour
{
    public CanvasToggle toggle;
    private bool checklistShown = false;
    public CleaningChecklistCanvas checklist;

    void Update()
    {
        if (!checklistShown)
        {
            toggle.showChecklist();
            checklist.ShowLivingRoomCanvas();
            checklistShown = true;
        }
    }
}
