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


    public GameObject objectToMonitor9;
    public GameObject objectToMonitor10;
    public GameObject objectToMonitor11;
    public GameObject objectToMonitor12;
    public GameObject objectToMonitor13;
    public GameObject objectToMonitor14;
    public GameObject objectToMonitor15;
    public GameObject objectToMonitor16;

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

            objectToMonitor9.SetActive(false);
            objectToMonitor10.SetActive(false);
            objectToMonitor11.SetActive(false);
            objectToMonitor12.SetActive(false);
            objectToMonitor13.SetActive(false);
            objectToMonitor14.SetActive(false);
            objectToMonitor15.SetActive(false);
            objectToMonitor16.SetActive(false);




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
            objectToMonitor5.activeSelf || objectToMonitor6.activeSelf || objectToMonitor7.activeSelf || objectToMonitor8.activeSelf || objectToMonitor9.activeSelf)
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
