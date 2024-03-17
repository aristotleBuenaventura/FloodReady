using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour
{
    public GameObject canvas;
    private bool isActive = false;

    private void Start()
    {
        canvas.SetActive(false); // Start with the canvas disabled 
    }

    // Update is called once per frame
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four)) // You can replace this with the Oculus button you want to use.
        {
            isActive = !isActive; // Toggle the isActive flag
            canvas.SetActive(isActive);        }
    }
}
