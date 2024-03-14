using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway4 : MonoBehaviour
{
    private double wall4amount;
    public IconforHW2 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Wall2_Audio;
    private bool isPlay = false;

    public void wall4(double cleanAmount)
    {
        wall4amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall4amount;
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
            if (Wall2_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall2_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
