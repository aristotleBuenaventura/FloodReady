using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room1414_1 : MonoBehaviour
{
    private double wall14amount;
    private double wall14_1amount;
    public IconforLRW3 check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;

    public void wall14(double cleanAmount)
    {
        wall14amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall14_1(double cleanAmount)
    {
        wall14_1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall14amount + wall14_1amount;
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
            checklist.checklist[4] = true;
            isSet = true;
        }
    }
}
