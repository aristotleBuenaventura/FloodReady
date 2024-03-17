using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway9 : MonoBehaviour
{
    private double wall9amount;
    public IconforHW5 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Wall5_Audio;
    private bool isPlay = false;

    public void wall9(double cleanAmount)
    {
        wall9amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall9amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 50)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[4] = true;
            if (Wall5_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall5_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
