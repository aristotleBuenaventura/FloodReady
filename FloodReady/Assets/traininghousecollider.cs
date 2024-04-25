using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traininghousecollider : MonoBehaviour
{
    public GameObject IMUCANVAS;
    public GameObject TrainingCanvas;
    public GameObject HouseFamiliarizationChecklist;
    // This function is called when another collider enters the trigger zone of this object
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to an object tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Activate the IMUCANVAS GameObject
            TrainingCanvas.SetActive(true);
            IMUCANVAS.SetActive(false);
            HouseFamiliarizationChecklist.SetActive(true);
        }
    }
}
