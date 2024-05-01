using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintFlashLightS2 : MonoBehaviour
{
    public GameObject TurnOnFlashlight;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    void Start()
    {
        TurnOnFlashlight.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {



            hintCanvas.TurnOnFLCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(2);
                canDeduct = true;
            }


        }
    }


}
