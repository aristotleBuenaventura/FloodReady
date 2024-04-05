using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintUseWaterNozzle : MonoBehaviour
{
    public GameObject Object;
    public ShowHintHTP hintCanvas;

    private bool canActivate = true; // Flag to track if canvas activation is allowed


    // Start is called before the first frame update
    void Start()
    {
        Object.SetActive(false);
    }

    // OnTriggerEnter is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Show the canvas
        if (other.CompareTag("Hand") && canActivate)
        {
            // Disable other hint colliders


            hintCanvas.ShowHintWaterNozzle();

  


        }
    }

}
