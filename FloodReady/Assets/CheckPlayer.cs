using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject playerTag;
    public GameObject objectsToDisable;
    public CheckNeighborhoodIcon checklist;
    public RecoveryCanvasController UsePhoneCanvas;
    public GameObject goBag;
    public GameObject DestroyHint;
    public TaskPercentage score;
    public TotalPoints points;
    public reportfallenIcon task;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // Check if the object to disable is active before disabling it
            if (objectsToDisable.activeSelf)
            {
                // Disable the object

                Destroy(DestroyHint);
                score.IncrementTaskPercentage(5);
                points.IncrementPoints(5);
                objectsToDisable.SetActive(false);
                checklist.SetCheckIconVisible(true);
                checklist.SetUncheckIconVisible(false);
                task.SetCheckIconVisible(true);
                task.SetUncheckIconVisible(false);
                UsePhoneCanvas.UsePhoneCanvas();
                goBag.SetActive(true);

            }
        }
    }
}
