using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintGasFind : MonoBehaviour
{
    public GameObject playerTag; // Assign the player GameObject to this variable in the Inspector
    public RecoveryCanvasController ShowclosegasleakCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            // If the gas bottle hint collides with the player, deactivate it
            gameObject.SetActive(false);
            ShowclosegasleakCanvas.ShowclosegasleakCanvas();
        }
    }
}
