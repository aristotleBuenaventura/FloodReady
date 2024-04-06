using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeAreaHTPHouse : MonoBehaviour
{
    public CanvasControllerHTP CanvasControllerHTP;
    public GameObject DestroyCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(DestroyCollider);
            CanvasControllerHTP.ShowWelcomeCanvas();
        }

    }
}
