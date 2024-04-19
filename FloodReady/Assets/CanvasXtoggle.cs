using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggleX : MonoBehaviour
{
    public GameObject canvas;
    private bool isActive = false;
    private bool isScriptActive = true;

    private void Start()
    {
        canvas.SetActive(false); // Start with the canvas disabled 
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isScriptActive)
            return;

        if (OVRInput.GetDown(OVRInput.Button.Three)) // You can replace this with the Oculus button you want to use.
        {
            isActive = !isActive; // Toggle the isActive flag
            canvas.SetActive(isActive);
        }
    }

    // Function to deactivate the script
    public void DeactivateScript()
    {
        isScriptActive = false;
    }
}
