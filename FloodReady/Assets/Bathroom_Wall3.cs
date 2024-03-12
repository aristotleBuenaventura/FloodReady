using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom_Wall3 : MonoBehaviour
{
    private double wall3amount;
    public IconforBRW3 check;
    private bool isSet = false;
    public Bathroom_Checklist checklist;

    public void wall3(double cleanAmount)
    {
        wall3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall3amount;
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
            checklist.checklist[3] = true;
            isSet = true;
        }
    }
}
