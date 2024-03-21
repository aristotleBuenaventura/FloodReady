using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintDialS2 : MonoBehaviour
{
    public GameObject Dial;
    public ShowHintCanvasScene2 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed


    void Start()
    {
        Dial.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

      
            hintCanvas.ShowDial161Canvas();
       
        }
    }
}

