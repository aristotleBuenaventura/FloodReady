using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway8 : MonoBehaviour
{
    private double wall8amount;
    public IconforHW4 check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Wall4_Audio;
    private bool isPlay = false;

    public void wall8(double cleanAmount)
    {
        wall8amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall8amount;
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
            if (Wall4_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall4_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
