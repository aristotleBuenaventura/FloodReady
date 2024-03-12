using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed_Room10 : MonoBehaviour
{
    private double wall10amount;
    public iconforBDW4 check;
    private bool isSet = false;
    public Bedroom_Checklist checklist;

    public void wall10(double cleanAmount)
    {
        wall10amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall10amount;
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
