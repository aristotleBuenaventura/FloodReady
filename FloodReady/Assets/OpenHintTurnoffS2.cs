using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintTurnoffS2 : MonoBehaviour
{
    public GameObject TurnoffBreaker;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    void Start()
    {
        TurnoffBreaker.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {



            hintCanvas.ShowMainBreakerCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(200);
                canDeduct = true;
            }


        }
    }

   
}
