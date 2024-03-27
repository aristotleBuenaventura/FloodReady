using UnityEngine;
using System.Collections;

public class LivingRoom_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false, false, false, false };
    public LivingRoom_Clean task;
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
            StartCoroutine(ShowKitchenCanvasAfterDelay(2f));
            // Disable the script
            
        }
    }

    IEnumerator ShowKitchenCanvasAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        task.SetCheckIconVisible(true);
        task.SetUncheckIconVisible(false);
        wall.KitchenColliders();
        score.IncrementTaskPercentage(10);
        points.IncrementPoints(1000);
        canvas.ShowcleankitchenCanvas();
        cleaningCanvas.ShowKitchenCanvas();
        enabled = false;
    }
}
