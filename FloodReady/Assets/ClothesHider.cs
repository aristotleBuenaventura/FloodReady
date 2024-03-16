using UnityEngine;

public class BasketHider : MonoBehaviour
{
    public GameObject ShowgatherDirtyclothesCanvas;

    public GameObject objectToEnable1;
 

    private bool objectsEnabled = false; // Track if objects are already enabled

    // Update is called once per frame
    private void Start()
    {
        objectToEnable1.SetActive(false);       
    }
    void Update()
    {
        // Check if the canvas becomes active during runtime and objects are not already enabled
        if (ShowgatherDirtyclothesCanvas.gameObject.activeSelf && !objectsEnabled)
        {
            // If canvas becomes active and objects are not already enabled, turn on all objects
            TurnOnObjects();
        }
    }

    // Method to turn on all GameObjects
    public void TurnOnObjects()
    {
        if (objectToEnable1 != null)
            objectToEnable1.SetActive(true);

        // Update the flag to indicate that objects are now enabled
        objectsEnabled = true;
    }
}
