using System.Collections;
using UnityEngine;

public class OpenHintCanned : MonoBehaviour
{
    public GameObject Canned;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
    public CanvasController CanvasController;

    // Start is called before the first frame update
    void Start()
    {
        Canned.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
        {
          

            hintCanvas.ShowCannedCanvas();
            CanvasController.HideAllCanvas();
            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }


         
        }
    }
  
}
