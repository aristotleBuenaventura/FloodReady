using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed_Room11112 : MonoBehaviour
{
    private double wall1amount;
    private double wall11amount;
    private double wall12amount;
    public iconforBDW1 check;
    private bool isSet = false;
    public Bedroom_Checklist checklist;

    public void wall1(double cleanAmount)
    {
        wall1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall11(double cleanAmount)
    {
        wall11amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall12(double cleanAmount)
    {
        wall12amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall1amount + wall11amount + wall12amount;
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
            checklist.checklist[0] = true;
            isSet = true;
        }
    }
}
