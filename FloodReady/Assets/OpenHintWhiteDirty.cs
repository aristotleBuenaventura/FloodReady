using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintWhiteDirty : MonoBehaviour
{
    public GameObject WhiteDirty;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
  

    void Start()
    {
        WhiteDirty.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)    
        {

            hintCanvas.ShowCloth1Canvas();
    
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }

}
