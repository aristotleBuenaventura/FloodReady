using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Ceiling12 : MonoBehaviour
{
    private double ceil1amount;
    private double ceil2amount;

    public void ceil1(double cleanAmount)
    {
        ceil1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void ceil2(double cleanAmount)
    {
        ceil2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = ceil1amount + ceil2amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;
        CleanAmountManager.UpdateCleanAmount(totalAmountInt);
    }
}
