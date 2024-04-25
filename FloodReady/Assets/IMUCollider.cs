using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMUCollider : MonoBehaviour
{
    public GameObject IMUCANVAS;
    public GameObject TrainingCanvas;
    public GameObject IMUChecklist;
    // This function is called when another collider enters the trigger zone of this object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to an object tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Activate the IMUCANVAS GameObject
            IMUChecklist.SetActive(true);
            TrainingCanvas.SetActive(false);
            IMUCANVAS.SetActive(true);
        }
    }
}
