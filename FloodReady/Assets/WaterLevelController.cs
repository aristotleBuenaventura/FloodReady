using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour
{
    public Timer timer; // Reference to your Timer script
    public Rigidbody waterRigidbody; // Reference to the Rigidbody component of the water object
    public float maxHeight = 5.0f; // Adjust this value to the maximum height of the water
    public float riseSpeed = 1.0f; // Adjust the speed at which the water rises

    void Update()
    {
        if (timer != null && waterRigidbody != null)
        {
            // Calculate the new water level based on the timer's remaining time
            float timerPercentage = timer.RemainingTime / timer.InitialTime; // Assuming you have an InitialTime property in Timer
            float newWaterY = transform.position.y + maxHeight * (1 - timerPercentage);

            // Calculate the distance to rise
            float distanceToRise = newWaterY - waterRigidbody.position.y;

            // Apply force to the Rigidbody to move the water
            Vector3 force = Vector3.up * (distanceToRise * riseSpeed);

            waterRigidbody.AddForce(force, ForceMode.Force);
        }
    }
}
