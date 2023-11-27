using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour
{
    public float risingSpeed = 0.01f; // Adjust the speed as needed
    private float nextRiseTime;
    public float targetWaterLevel; // New variable to store the desired water level

    private void Start()
    {
        nextRiseTime = Time.time + 1f; // Start rising after 1 second
        targetWaterLevel = transform.position.y; // Set initial water level to current position
    }

    public bool IsWaterRising()
    {
        // Check if the target water level is higher than the initial water level

        Debug.Log("WATER TRUE TRUE");
        return targetWaterLevel > transform.position.y;
    }

    void Update()
    {
        Debug.Log("WaterLevelController Update");
        if (Time.time >= nextRiseTime)
        {
            RiseWater();
        }
    }

    void RiseWater()
    {
        targetWaterLevel += risingSpeed; // Adjust the target water level

        transform.position = new Vector3(transform.position.x, targetWaterLevel, transform.position.z);

        // Ensure rotation remains zero for all axes
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        Debug.Log("WATER RISE");

        nextRiseTime += 0.01f; // Set the next rise time
    }
}
