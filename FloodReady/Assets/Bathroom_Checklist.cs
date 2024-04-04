using UnityEngine;
using System.Collections;

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
    public CleanAllRoomsIcon checklistIcon;
    public GameObject nozzle;

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
            
            StartCoroutine(ShowPlungerCanvasAfterDelay(2f));
            score.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            enabled = false;
        }

        IEnumerator ShowPlungerCanvasAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            if(checklistIcon != null)
            {

            checklistIcon.SetCheckIconVisible(true);
            checklistIcon.SetUncheckIconVisible(false);
            }
            //cleaningCanvas.deactivate();
            mainCanvas.ShowfindPlungerCanvas();
            wall.BathroomColliders();
            nozzle.SetActive(false);
            plunger.SetActive(true);
            // Disable the script
            
        }
    }
}
