using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageCanvas : MonoBehaviour
{
    public Canvas canvas;
    private OVRPlayerController ovrPlayerController;

    public void Start()
    {
        ovrPlayerController = GetComponent<OVRPlayerController>();
        canvas.enabled = true;
    }

    // Update is called once per frame
    public void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            canvas.enabled = !canvas.enabled;
            Debug.Log("Button pressed. Canvas visibility: " + canvas.enabled);
        }

    }

    public void OpenCanvasAgain()
    {
        canvas.enabled = true;
    }
}
