using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bedroom_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false };
    public Bedroom_Clean task;
    public CleaningChecklistCanvas cleaningCanvas;
    public RecoveryCanvasController canvas;
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
            StartCoroutine(ShowBathroomCanvasAfterDelay(2f));
            score.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            // Disable the script
            enabled = false;
        }

        IEnumerator ShowBathroomCanvasAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            canvas.ShowcleanBathRoomCanvas();
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            cleaningCanvas.ShowBathRoomCanvas();
            wall.BathroomColliders();
            
        }
    }
}