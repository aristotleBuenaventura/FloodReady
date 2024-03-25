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
    public RecoveryCanvasController RecoveryCanvasController;

    void Start()
    {
        BlueDirty.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowCloth4Canvas();
            RecoveryCanvasController.HideAllCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }
}
