using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    public TVController tvController;

    private bool isButtonDown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurnOnButton"))
        {
            if (isButtonDown)
            {
                tvController.TurnOff();
                Debug.Log("Button Pressed: TV Turned Off");
            }
            else
            {
                tvController.TurnOn();
                Debug.Log("Button Pressed: TV Turned On");
            }

            isButtonDown = !isButtonDown;
        }
    }
}
