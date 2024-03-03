using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Flooring123 : MonoBehaviour
{
    private double floor1amount;
    private double floor2amount;
    private double floor3amount;

    public void floor1(double cleanAmount)
    {
        floor1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void floor2(double cleanAmount)
    {
        floor2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void floor3(double cleanAmount)
    {
        floor3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = floor1amount + floor2amount + floor3amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;
        CleanAmountManager.UpdateCleanAmount(totalAmountInt);
    }
}
