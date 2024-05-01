using System.Collections;
using UnityEngine;

public class OpenHintWhistle : MonoBehaviour
{
    public GameObject Whistle;
    public ShowHintCanvas hintCanvas;

    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    // Start is called before the first frame update
    void Start()
    {
        Whistle.SetActive(false);
    }

    // OnTriggerEnter is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Show the canvas
        if (other.CompareTag("Hand") && canActivate)
        {
            // Disable other hint colliders


            hintCanvas.ShowWhistleCanvas();
      
            if (!canDeduct)
            {
                points.DecrementPoints(1);
                canDeduct = true;
            }


        }
    }



}
