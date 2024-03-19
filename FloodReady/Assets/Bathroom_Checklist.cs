using UnityEngine;

public class Bathroom_Checklist : MonoBehaviour
{
    public bool[] checklist = { false, false, false, false, false, false };
    public Bathroom_Clean task;
    public CleaningChecklistCanvas cleaningCanvas;
    public RecoveryCanvasController mainCanvas;
    public CleaningCollider wall;
    public TaskPercentage score;
    public GameObject plunger;
    public TotalPoints points;

    void Start()
    {
        plunger.SetActive(false);
    }

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
            cleaningCanvas.deactivate();
            mainCanvas.ShowfindPlungerCanvas();
            wall.BathroomColliders();
            score.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            plunger.SetActive(true);
            // Disable the script
            enabled = false;
        }
    }
}
