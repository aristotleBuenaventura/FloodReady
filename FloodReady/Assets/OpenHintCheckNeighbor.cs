using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintCheckNeighbor : MonoBehaviour
{
    public GameObject CheckNeighbor;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        CheckNeighbor.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowCheckNeighborhoodCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }

        }
    }

}
