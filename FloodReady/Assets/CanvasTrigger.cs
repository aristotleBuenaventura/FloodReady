using UnityEngine;

public class CanvasTrigger : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    public RecoveryCanvasController canvasController;
    public GameObject showchecwholehouse; // Reference to the showchecwholehouse GameObject
    public CheckHouse checkHouseScript; // Reference to the CheckHouse script

    private bool canvasShown = false;

    void Update()
    {
        // Check if showchecwholehouse canvas is active and enabled
        if (!showchecwholehouse || !showchecwholehouse.activeInHierarchy || !showchecwholehouse.activeSelf || !showchecwholehouse.GetComponent<Canvas>().enabled)
        {
            // If it's not active or not enabled, disable this script
            enabled = false;
            return; // Exit the update loop
        }

        // Check if CheckHouse script is not already enabled
        if (!checkHouseScript.enabled)
        {
            // If the CheckHouse script is not enabled, enable it
            checkHouseScript.enabled = true;
        }

        // Check if all GameObjects are disabled
        bool allDisabled = true;
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj.activeSelf)
            {
                allDisabled = false;
                break;
            }
        }

        // If all GameObjects are disabled and canvas has not been shown yet, show the canvas
        if (allDisabled && !canvasShown)
        {
            canvasController.ShowfindnozzleCanvas();
            canvasShown = true; // Set canvasShown to true to indicate that the canvas has been shown
            // Disable this script to prevent further updates
            enabled = false;
        }
    }
}
