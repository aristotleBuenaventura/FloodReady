using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintPlungeToilet : MonoBehaviour
{
    public GameObject PlungeToilet;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;

    void Start()
    {
        PlungeToilet.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowPlungerToiletCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }

}
