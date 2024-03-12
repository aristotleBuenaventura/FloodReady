using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway1617 : MonoBehaviour
{
    private double wall16amount;
    private double wall17amount;
    public IconforHW7 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;

    public void wall16(double cleanAmount)
    {
        wall16amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall17(double cleanAmount)
    {
        wall17amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall16amount + wall17amount;
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
