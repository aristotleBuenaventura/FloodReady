using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_Room2 : MonoBehaviour
{
    private double wall2amount;
    public IconforKW2 check;
    private bool isSet = false;
    public Kitchen_Checklist checklist;

    public void wall2(double cleanAmount)
    {
        wall2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall2amount;
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
            checklist.checklist[1] = true;
            isSet = true;
        }
    }
}
