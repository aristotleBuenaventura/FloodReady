using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_Room7 : MonoBehaviour
{
    private double wall7amount;
    public IconforKW4 check;
    private bool isSet = false;

    public void wall7(double cleanAmount)
    {
        wall7amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall7amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 95)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            isSet = true;
        }
    }
}
