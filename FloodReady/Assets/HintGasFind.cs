using UnityEngine;

public class HintGasFind : MonoBehaviour
{
    public GameObject playerTag; // Assign the player GameObject to this variable in the Inspector
    public GameObject objectToDisable; // Assign the GameObject you want to disable to this variable in the Inspector
    public RecoveryCanvasController ShowclosegasleakCanvas;
    private Collider gasFindHintCollider; // Reference to the GasFindHint collider
    private bool hasShownCanvas = false; // Flag to track if canvas has been shown
    public TotalPoints points;
    public gasleakIcon check;
    public TaskPercentage task;
    public LookForGasLeakIcon checklist;
    public GameObject GasHissingHint;

    void Start()
    {
        // Get the collider component of the GasFindHint
        gasFindHintCollider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag && !hasShownCanvas)
        {
            // Show the canvas
            ShowclosegasleakCanvas.ShowclosegasleakCanvas();
            objectToDisable.SetActive(false);
            // Disable the collider to prevent further collisions
            gasFindHintCollider.enabled = false;

            // Set the flag to true to indicate that the canvas has been shown
            hasShownCanvas = true;
            Destroy(GasHissingHint);
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.SetCheckIconVisible(true);
            checklist.SetUncheckIconVisible(false);
            task.IncrementTaskPercentage(10);
            points.IncrementPoints(1000);
        }
    }
}
