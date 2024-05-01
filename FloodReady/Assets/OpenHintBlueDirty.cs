using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintBlueDirty : MonoBehaviour
{
    public GameObject BlueDirty;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    void Start()
    {
        BlueDirty.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowCloth4Canvas();
    
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }

        }
    }
}
