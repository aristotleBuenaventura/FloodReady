using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed_Floor : MonoBehaviour
{
    private double flooramount;
    public iconforBDF check;
    private bool isSet = false;
    public Bedroom_Checklist checklist;

    public void floor (double cleanAmount)
    {
        flooramount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = flooramount;
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
