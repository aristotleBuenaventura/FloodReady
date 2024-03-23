using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintPhoneS2 : MonoBehaviour
{
    public GameObject Phone;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
    public EscapeCanvasController EscapeCanvasController;

    void Start()
    {
        Phone.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowLocateEmergencyDeviceCanvas();
            EscapeCanvasController.HideAllCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }
        }
    }

   
   }
