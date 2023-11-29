using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour
{
    public float risingSpeed = 0.01f;
    private float nextRiseTime;

    public float maxWaterLevel;

    private void Start()
    {
        nextRiseTime = Time.time + 1f;
    }

    public bool IsWaterRising()
    {
        return transform.position.y < maxWaterLevel;
    }

    void Update()
    {
        if (Time.time >= nextRiseTime && IsWaterRising())
        {
            RiseWater();
        }
    }

    void RiseWater()
    {
        transform.Translate(Vector3.up * risingSpeed, Space.World);
        nextRiseTime += 0.01f;
    }
}
