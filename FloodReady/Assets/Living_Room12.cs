using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room12 : MonoBehaviour
{
    private double wall1amount;
    private double wall2amount;   

    public void wall1(double cleanAmount)
    {
        wall1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall2(double cleanAmount)
    {
        wall2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall1amount + wall2amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;
        CleanAmountManager.UpdateCleanAmount(totalAmountInt);
    }
}
