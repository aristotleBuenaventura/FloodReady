using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_Ceiling : MonoBehaviour
{
    private double ceilingamount;
    public IconforKC check;
    private bool isSet = false;
    public Kitchen_Checklist checklist;
    public AudioSource Ceiling_Audio;
    private bool isPlay = false;

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
            if (Ceiling_Audio != null && !isPlay)
            {
                // Play the flush sound
                Ceiling_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
