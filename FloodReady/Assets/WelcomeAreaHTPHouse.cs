using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeAreaHTPHouse : MonoBehaviour
{
    public CanvasControllerHTP CanvasControllerHTP;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            CanvasControllerHTP.ShowWelcomeCanvas();
        }

    }
}
