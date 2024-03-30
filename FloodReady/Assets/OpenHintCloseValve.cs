using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintCloseValve : MonoBehaviour
{
    public GameObject closeValve;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        closeValve.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowGasValveCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }

}
