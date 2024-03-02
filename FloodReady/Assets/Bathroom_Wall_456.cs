using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom_Wall_456 : MonoBehaviour
{
    private double wall4amount;
    private double wall5amount;
    private double wall6amount;

    public void wall4(double cleanAmount)
    {
        wall4amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall5(double cleanAmount)
    {
        wall5amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall6(double cleanAmount)
    {
        wall6amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall4amount + wall5amount + wall6amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;
        CleanAmountManager.UpdateCleanAmount(totalAmountInt);
    }

}
