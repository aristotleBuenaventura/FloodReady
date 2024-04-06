using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChecklistHTPHouse : MonoBehaviour
{
    public CanvasControllerHTP CanvasControllerHTP;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            CanvasControllerHTP.OpenChecklistCanvas();
        }

    }
}
