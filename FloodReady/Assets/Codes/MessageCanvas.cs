using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageCanvas : MonoBehaviour
{
    public Canvas canvas;
    public float delayTime = 2.0f; // Adjust the delay time as needed
    public float jumpForce = 5f;
    private bool isGrounded = true;
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

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Jump();
            Debug.Log("jump ");
        }
    }

    void Jump()
    {
        // Add a force to make the player jump
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        // Set isGrounded to false to prevent multiple jumps until the player lands
        isGrounded = false;

        // Invoke a method to reset isGrounded after a delay (adjust as needed)
        Invoke("ResetIsGrounded", 0.5f);
    }

    public void OpenCanvasAgain()
    {
        canvas.enabled = true;
    }
}
