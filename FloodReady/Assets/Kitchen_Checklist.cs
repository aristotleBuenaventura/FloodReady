using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false };
    public Kitchen_Clean task;
    public CleaningChecklistCanvas cleaningCanvas;
    public RecoveryCanvasController mainCanvas;
    public CleaningCollider wall;
    public TaskPercentage score;
    public TotalPoints points;

    void Update()
    {
        // Check if all elements in the checklist are true
        bool allTrue = true;
        for (int i = 0; i < checklist.Length; i++)
        {
            if (!checklist[i])
            {
                allTrue = false;
                break;
            }
        }

        // If all elements are true, display debug.log("Finish")
        if (allTrue)
        {
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            cleaningCanvas.ShowHallwayCanvas();
            mainCanvas.ShowcleansecondhallwayCanvas();
            wall.SecondFloorColliders();
            score.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            // Disable the script
            enabled = false;
        }
    }
}
