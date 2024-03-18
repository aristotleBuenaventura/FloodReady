using UnityEngine;
using System.Collections; // Add this line to include the System.Collections namespace

public class OpenHintCanvas : MonoBehaviour
{
    public ShowHintCanvas showHintCanvas;
    private bool canTrigger = true; // Flag to control trigger activation

    public GameObject objectToMonitor1;
    public GameObject objectToMonitor2;
    public GameObject objectToMonitor3;
    public GameObject objectToMonitor4;
    public GameObject objectToMonitor5;
    public GameObject objectToMonitor6;
    public GameObject objectToMonitor7;
    public GameObject objectToMonitor8;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the player or controller
        if (other.CompareTag("Hand") && canTrigger)
        {
            // Show the next canvas
            objectToMonitor1.SetActive(true);
            objectToMonitor2.SetActive(true);
            objectToMonitor3.SetActive(true);
            objectToMonitor4.SetActive(true);
            objectToMonitor5.SetActive(true);
            objectToMonitor6.SetActive(true);
            objectToMonitor7.SetActive(true);
            objectToMonitor8.SetActive(true);
        
           
        }
    }
}
