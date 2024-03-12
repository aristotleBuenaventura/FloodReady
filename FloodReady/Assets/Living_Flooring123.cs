using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Flooring123 : MonoBehaviour
{
    private double floor1amount;
    private double floor2amount;
    private double floor3amount;
    public IconforLRF check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;

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

        if (totalAmountInt >= 1)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[6] = true;
            isSet = true;
        }
    }
}
