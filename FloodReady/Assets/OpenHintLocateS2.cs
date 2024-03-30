using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintLocateS2 : MonoBehaviour
{
    public GameObject LocatePryBar;
    public ShowHintCanvasScene2 hintCanvas;
    public TotalPoints points;
    private bool canDeduct = false;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    

    void Start()
    {
        LocatePryBar.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {


            hintCanvas.ShowPryBarCanvas();
            
            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }


        }
    }

   
    }
