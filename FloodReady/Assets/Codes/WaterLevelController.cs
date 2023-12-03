using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour
{
    public float risingSpeed = 0.01f;
    private float nextRiseTime;
    public float maxWaterLevelBreaker; // Maximum water level when the breaker is turned off
    public float maxWaterLevelPlayer;  // Maximum water level when the player is detected

    public LevelThreeWater levelThreeWater; // Reference to the LevelThreeWater script

    private bool canRiseWater = false;

    private void Start()
    {
        nextRiseTime = Time.time + 0.01f;
    }

    // You need to set this method to be called when the turnoffmainbreaker canvas has been finished
    public void SetCanRiseWater()
    {
        canRiseWater = true;
    }

    public bool IsWaterRising()
    {
        return canRiseWater && transform.position.y < GetMaxWaterLevel();
    }

    private float GetMaxWaterLevel()
    {
        if (levelThreeWater != null && levelThreeWater.PlayerDetected())
        {
            return maxWaterLevelPlayer;
        }
        else
        {
            return maxWaterLevelBreaker;
        }
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
        transform.Translate(Vector3.up * risingSpeed * Time.deltaTime, Space.World);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, GetMaxWaterLevel()), transform.position.z);

        nextRiseTime += 0.01f;
    }
}
