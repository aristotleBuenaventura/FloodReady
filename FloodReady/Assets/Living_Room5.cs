using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room5 : MonoBehaviour
{
    private double wall5amount;
    public IconforLRW5 check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;

    public void wall4(double cleanAmount)
    {
        wall5amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall5amount;
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
            checklist.checklist[8] = true;
            isSet = true;
        }
    }
}
