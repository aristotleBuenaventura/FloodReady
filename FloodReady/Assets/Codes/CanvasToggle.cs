using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour
{
    public Canvas canvas;

    private void Start()
    {
        canvas.enabled = false; // Start with the canvas disabled.
    }

    // Update is called once per frame
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four)) // You can replace this with the Oculus button you want to use.
        {
            canvas.enabled = !canvas.enabled; // Toggle the canvas.
        }
    }
}





