using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopperHTPBalcony : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    public GameObject Collider;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the objects to monitor
        InitializeObjectsToMonitor();
    }

    // Function to initialize the objects to monitor
    void InitializeObjectsToMonitor()
    {
        // Remove null objects from the list
        List<GameObject> validObjects = new List<GameObject>();
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj != null)
            {
                validObjects.Add(obj);
            }
        }
        objectsToMonitor = validObjects.ToArray();
    }

    public void DisableCollider()
    {
        if (Collider != null)
        {
            Collider.SetActive(false);
        }
    }

    void Update()
    {
        // Check if all elements in the checklist are true
        // Check if all GameObjects are disabled
        bool allDisabled = true;
        foreach (GameObject obj in objectsToMonitor)
        {
            if (obj != null && obj.activeSelf)
            {
                allDisabled = false;
                break;
            }
        }

        // If all GameObjects are disabled and canvas has not been shown yet, show the canvas
        if (allDisabled)
        {
            DisableCollider();
        }
    }
}
