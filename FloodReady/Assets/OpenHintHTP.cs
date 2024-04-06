using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintHTP : MonoBehaviour
{
    public ShowHintHTP showHintCanvas;
    private bool canTrigger = true; // Flag to control trigger activation

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



    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the player or controller
        if (other.CompareTag("Hand") && canTrigger)
        {

            SetObjectActive(objectToMonitor1, true);
            SetObjectActive(objectToMonitor2, true);
            SetObjectActive(objectToMonitor3, true);
            SetObjectActive(objectToMonitor4, true);
            SetObjectActive(objectToMonitor5, true);
            SetObjectActive(objectToMonitor6, true);
            SetObjectActive(objectToMonitor7, true);
            SetObjectActive(objectToMonitor8, true);
            SetObjectActive(objectToMonitor9, true);
            SetObjectActive(objectToMonitor10, true);

        }
    }

    private void SetObjectActive(GameObject obj, bool active)
    {
        // Check if the object reference is not null
        if (obj != null)
        {
            obj.SetActive(active);
        }
    }
}
