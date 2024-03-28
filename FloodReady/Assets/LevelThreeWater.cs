// LevelThreeWater.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThreeWater : MonoBehaviour
{
    private bool playerDetected = false;
    private WaterLevelController waterLevelController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER WALKS");
            
            playerDetected = true;

        }
    }

    public bool PlayerDetected()


    {

        if (waterLevelController != null)
        {
            waterLevelController.SetCanRiseWater(); // Assuming you have a method like SetCanRiseWater in WaterLevelController

        }
        return playerDetected;
    }
}
