using System.Collections;
using UnityEngine;

public class OpenHintRetrieve : MonoBehaviour
{
    public GameObject Retrieve;
    public ShowHintCanvas hintCanvas;

    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;


    // Start is called before the first frame update
    void Start()
    {
        Retrieve.SetActive(false);
    }

    // OnTriggerEnter is called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Show the canvas
        if (other.CompareTag("Hand") && canActivate)
        {
            // Disable other hint colliders


            hintCanvas.ShowRetrieveCanvas();

            if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }


        }
    }



}
