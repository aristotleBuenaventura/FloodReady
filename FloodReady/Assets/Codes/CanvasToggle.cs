using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour
{
    public GameObject canvas;
    private bool isActive = false;
    public bool isOk = false;

    public void Start()
    {
        canvas.SetActive(false); // Start with the canvas disabled 
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
        canvas.SetActive(true); // Show the canvas every time showChecklist() is called
        isOk = true;
    }
}
