using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHintPlungeToilet : MonoBehaviour
{
    public GameObject PlungeToilet;
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

  
            if (!canDeduct)
            {
                points.DecrementPoints(50);
                canDeduct = true;
            }

        }
    }

}
