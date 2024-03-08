using UnityEngine;

public class CloseHint : MonoBehaviour
{
    public GameObject objectToMonitor1;
    public GameObject objectToMonitor2;
    public GameObject objectToMonitor3;
    public GameObject objectToMonitor4;
    public GameObject objectToMonitor5;
    public GameObject objectToMonitor6;
    public GameObject objectToMonitor7;
    public GameObject objectToMonitor8;

    public GameObject objectToShow;
    public ShowHintCanvas showHintCanvas;

    private bool objectShownOnExit = false;

    private void OnTriggerExit(Collider other)
    {
        // Check if the collider that exited the trigger is the player or controller
        if (other.CompareTag("Hand"))
        {
            // Hide the object to show if it is active and it wasn't shown during OnTriggerExit
            if (objectToShow.activeSelf && !objectShownOnExit)
            {
                objectToShow.SetActive(false);
                Debug.Log("Object to show was hidden during OnTriggerExit");
            }

            // Hide all canvas elements
            showHintCanvas.HideAllCanvas();

            // Reset the flag
            objectShownOnExit = false;
        }
    }

    private void Update()
    {
        // Check if any of the monitored objects are active
        if (objectToMonitor1.activeSelf || objectToMonitor2.activeSelf || objectToMonitor3.activeSelf || objectToMonitor4.activeSelf ||
            objectToMonitor5.activeSelf || objectToMonitor6.activeSelf || objectToMonitor7.activeSelf || objectToMonitor8.activeSelf)
        {
            // Show the object to show
            objectToShow.SetActive(true);
            objectShownOnExit = true;
            Debug.Log("Object to show is active now");
        }
        else
        {
            // If no monitored objects are active, hide the object to show
            objectToShow.SetActive(false);
            Debug.Log("Object to show is inactive now");
        }
    }
}
