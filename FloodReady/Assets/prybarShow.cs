using UnityEngine;

public class PrybarShow : MonoBehaviour
{
    public EscapeCanvasController escapeCanvasController;
    private bool hasInteracted = false;
    public TryToLeaveTheHouseChecklist check;
    public TryToLeaveTheHouseIcon task;
    public TotalPoints points;
    public TaskPercentage taskpoints;
    public GameObject DestroyHint;

    void Start()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasInteracted && other.CompareTag("Player"))
        {
            Debug.Log("PLAYER WALKS");

            // Call the ShowGoRoofTop method in EscapeCanvasController with the parameter true
            escapeCanvasController.ShowGoRoofTop(true);
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);
            taskpoints.IncrementTaskPercentage(10);
            points.IncrementPoints(10);
            // Set the flag to true to indicate that the interaction has occurred
            hasInteracted = true;
            Destroy(DestroyHint);

        }
    }
}
