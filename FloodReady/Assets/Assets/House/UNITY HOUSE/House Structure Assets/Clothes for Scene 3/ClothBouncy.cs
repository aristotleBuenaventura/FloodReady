using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothBouncy : MonoBehaviour
{
    // Variables for controlling the bouncy effect
    public float bounceForce = 1.0f;
    public float bounceRadius = 0.5f;
    public LayerMask grabbableLayer;

    private Rigidbody rb;
    private bool isGrabbed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the object is being grabbed
        if (isGrabbed)
        {
            ApplyBouncyEffect();
        }
    }

    void FixedUpdate()
    {
        // Check if the object is being grabbed by OVRGrabber
        isGrabbed = CheckIfGrabbed();
    }

    bool CheckIfGrabbed()
    {
        OVRGrabber[] grabbers = FindObjectsOfType<OVRGrabber>();
        foreach (var grabber in grabbers)
        {
            if (grabber.grabbedObject == gameObject)
            {
                return true;
            }
        }
        return false;
    }

    void ApplyBouncyEffect()
    {
        // Apply a force in a random direction to create a bouncy effect
        Vector3 randomDirection = Random.insideUnitSphere * bounceRadius;
        rb.AddForce(randomDirection * bounceForce, ForceMode.Impulse);
    }
}