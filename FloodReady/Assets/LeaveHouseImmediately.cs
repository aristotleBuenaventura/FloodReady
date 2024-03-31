using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveHouseImmediately : MonoBehaviour
{

    public TotalPoints points;
    private bool hasInteracted = false;
    public iconforleavethehouse leavethehousecheck;
    public TaskPercentage leave;
    public leavethehouseicon checklist;
    public CanvasController canvas;
    public GameObject portal;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collider is with an object tagged as "Player" and the interaction hasn't occurred yet
        if (!hasInteracted && other.CompareTag("Player"))
        {
            points.IncrementPoints(1000);
            leave.IncrementTaskPercentage(10);
            leavethehousecheck.SetCheckIconVisible(true);
            leavethehousecheck.SetUncheckIconVisible(false);
            checklist.SetCheckIconVisible(true);
            checklist.SetUncheckIconVisible(false);
            canvas.ShowCirclePoint();
            portal.SetActive(true);
            hasInteracted = true;
        }
    }
}
