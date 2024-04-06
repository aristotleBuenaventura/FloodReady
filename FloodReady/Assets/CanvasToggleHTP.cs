using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggleHTP : MonoBehaviour
{
    public GameObject canvas;
    private bool isActive = false;

    public void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four)) // You can replace this with the Oculus button you want to use.
        {
            isActive = !isActive; // Toggle the isActive flag
            canvas.SetActive(isActive);
        }
    }

    public void showChecklist()
    {
        isActive = true; // Set isActive to true
        canvas.SetActive(true); // Show the canvas
    }
}
