using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom_Ceiling : MonoBehaviour
{
    private double ceilingamount;
    public IconforBRC check;
    private bool isSet = false;
    public Bathroom_Checklist checklist;

    public void ceiling(double cleanAmount)
    {
        ceilingamount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = ceilingamount;
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
            checklist.checklist[5] = true;
            isSet = true;
        }
    }
}
