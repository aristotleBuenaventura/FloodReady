using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintPhoneS2 : MonoBehaviour
{
    public GameObject Phone;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed

    void Start()
    {
        Phone.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowLocateEmergencyDeviceCanvas();

        }
    }

   
   }
