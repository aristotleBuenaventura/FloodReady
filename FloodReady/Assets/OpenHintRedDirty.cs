using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintRedDirty : MonoBehaviour
{
    public GameObject RedDirty;
    public ShowHintCanvasScene3 hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
    public RecoveryCanvasController RecoveryCanvasController;

    void Start()
    {
        RedDirty.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {

            hintCanvas.ShowCloth5Canvas();
            RecoveryCanvasController.HideAllCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }
}
