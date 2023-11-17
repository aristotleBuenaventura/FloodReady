using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    public TVController tvController;
    public float buttonCooldown = 2.0f; // Adjust the cooldown time as needed
    public CanvasController messageCanvas;
    private bool isButtonDown = false;
    private bool canPressButton = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurnOnButton") && canPressButton)
        {
            StopAllCoroutines(); // Stop any existing coroutines

            if (isButtonDown)
            {
                tvController.TurnOff();
                Debug.Log("Button Pressed: TV Turned Off");
                CallSwitchCanvasAfterDelayTV();
            }
            else
            {
                tvController.TurnOn();
                CallSwitchCanvasAfterDelayTV();
                Debug.Log("Button Pressed: TV Turned On");
            }

            isButtonDown = !isButtonDown;
            canPressButton = false;
            StartCoroutine(ButtonCooldown());
        }
    }


    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(buttonCooldown);
        canPressButton = true;
    }

    public void CallSwitchCanvasAfterDelayTV()
    {
        StartCoroutine(messageCanvas.SwitchCanvasAfterDelayTV());
        Debug.Log("Go bag working");
    }
}
