using System.Collections;
using UnityEngine;

public class OpenHintClothes : MonoBehaviour
{
    public GameObject Clothes;
    public ShowHintCanvas hintCanvas;
    private bool canActivate = true; // Flag to track if canvas activation is allowed
    public TotalPoints points;
    private bool canDeduct = false;
    public CanvasController CanvasController;

    // Start is called before the first frame update
    void Start()
    {
        Clothes.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand") && canActivate)
 

            hintCanvas.ShowClothesCanvas();
        CanvasController.HideAllCanvas();
        if (!canDeduct)
            {
                points.DecrementPoints(100);
                canDeduct = true;
            }



            // Check if HintCanvasManager exists

         
        }
    }
    

