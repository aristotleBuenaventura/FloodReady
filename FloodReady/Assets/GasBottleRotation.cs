using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasBottleRotation : MonoBehaviour
{
    // Rotation speed when not colliding
    public float rotationSpeed = 100.0f;

    // Rotation speed when colliding
    public float collisionRotationSpeed = 20.0f;

    // Flag to track whether rotation has occurred
    private bool hasRotated = false;

    void Start()
    {
        // You can add any initialization code here if needed
    }

    void Update()
    {
        // Rotate the GasBottle around its up axis
        if (!hasRotated)
        {
            RotateGasBottle(rotationSpeed);
        }
    }

    void RotateGasBottle(float speed)
    {
        // Rotate the GasBottle around its up axis
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Hand" and rotation has not occurred
        if (collision.gameObject.CompareTag("Hand") && !hasRotated)
        {
            // Rotate slowly when colliding with an object tagged as "Hand"
            RotateGasBottle(collisionRotationSpeed);

            // Set the flag to true to indicate that rotation has occurred
            hasRotated = true;
        }
    }
}
