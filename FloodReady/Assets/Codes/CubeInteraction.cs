using UnityEngine;
using OculusSampleFramework;
using System.Collections;

public class CubeInteraction : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    private bool isGrabbed = false;
    private bool canToggleLights = true;

    private void Start()
    {
        // Add OVRGrabbable component to the cube
        ovrGrabbable = gameObject.AddComponent<OVRGrabbable>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");

        // Check if the collider belongs to the cube and is currently grabbed
        if (other.gameObject == gameObject && isGrabbed && canToggleLights)
        {
            // Toggle lights code remains the same
            StartCoroutine(ButtonCooldown());
        }
    }

    private IEnumerator ButtonCooldown()
    {
        canToggleLights = false;
        // Simulate your light toggling logic
        Debug.Log("Lights Toggled");
        yield return new WaitForSeconds(2.0f); // Adjust the cooldown time as needed
        canToggleLights = true;
    }

    private void Update()
    {
        // Check if the cube is currently grabbed
        isGrabbed = ovrGrabbable.isGrabbed;

        // Rotate the cube if it's currently grabbed
        if (isGrabbed)
        {
            // Your rotation logic here
            transform.Rotate(Vector3.up * Time.deltaTime * 30.0f);
        }
    }
}
