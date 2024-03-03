using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room678 : MonoBehaviour
{
    private double wall6amount;
    private double wall7amount;
    private double wall8amount;

    public void wall6(double cleanAmount)
    {
        wall6amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall7(double cleanAmount)
    {
        wall7amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall8(double cleanAmount)
    {
        wall8amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall6amount + wall7amount + wall8amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;
        CleanAmountManager.UpdateCleanAmount(totalAmountInt);
    }
}
