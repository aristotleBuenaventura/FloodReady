using UnityEngine;

public class CheckHouse : MonoBehaviour
{
    public GameObject showchecwholehouse;

    public GameObject objectToEnable1;
    public GameObject objectToEnable2;
    public GameObject objectToEnable3;
    public GameObject objectToEnable4;
    public GameObject objectToEnable5;

    private bool objectsEnabled = false; // Track if objects are already enabled

    // Update is called once per frame
    void Update()
    {
        // Check if the canvas becomes active during runtime and objects are not already enabled
        if (showchecwholehouse.gameObject.activeSelf && !objectsEnabled)  
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

        if (objectToEnable2 != null)
            objectToEnable2.SetActive(true);

        if (objectToEnable3 != null)
            objectToEnable3.SetActive(true);

        if (objectToEnable4 != null)
            objectToEnable4.SetActive(true);

        if (objectToEnable5 != null)
            objectToEnable5.SetActive(true);

        // Update the flag to indicate that objects are now enabled
        objectsEnabled = true;
    }
}
