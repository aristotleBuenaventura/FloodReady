using System.Collections;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class PryBarLogic : MonoBehaviour
{
    public locateIcon survivalToolIcon; // Reference to the LocateIcon script

    // Cooldown time in seconds
    public float interactionCooldown = 2f;

    private float lastInteractionTime;
    private bool hasInteracted = false;
    private bool hasIncrementedPercentage = false; // New flag to track if percentage has been incremented
    public TaskPercentage PryBarPercentage;
    public EscapeCanvasController escapeCanvasController;
    public LocateTheSurvivalToolScene2Icon task;
    public TotalPoints points;
    public GameObject hintPrybar;
    

    public void Update()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.lossyScale / 2f, transform.rotation);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("BreakableWindow"))
            {
                // Ensure the PryBar is the only object that can break the window
                BreakableWindow window = collider.GetComponent<BreakableWindow>();
                if (window != null && !window.IsBroken)
                {
                    window.HandleCollision();

                    if (window.IsLastWindow()) // Check if it's the last window
                    {
                        window.DestroyWindow();
                        // Optionally mark the task as done for breaking the last window


                    }

                    // Mark the "Break a Window" task as done


                    // Update the last interaction time
                    lastInteractionTime = Time.time;

                    // Assuming survivalToolIcon is not null, set the check and uncheck icons accordingly


                    // Set the flag to true to ensure this block is not executed again

                }
            }
        }

        // Mark the "Retrieve a Survival Tool" task as done
        

        // Check if the percentage has already been incremented
        if (!hasIncrementedPercentage)
        {
            escapeCanvasController.ShowBreakWindowCanvas();
            PryBarPercentage.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            Destroy(hintPrybar);
            survivalToolIcon.SetCheckIconVisible(true);
            survivalToolIcon.SetUncheckIconVisible(false);
            hasIncrementedPercentage = true;
        }
    }


}

