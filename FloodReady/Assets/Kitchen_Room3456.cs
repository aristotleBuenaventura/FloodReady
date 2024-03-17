using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen_Room3456 : MonoBehaviour
{
    private double wall3amount;
    private double wall4amount;
    private double wall5amount;
    private double wall6amount;
    public IconforKW3 check;
    private bool isSet = false;
    public Kitchen_Checklist checklist;
    public AudioSource Wall3_Audio;
    private bool isPlay = false;

    public void wall3(double cleanAmount)
    {
        wall3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall4(double cleanAmount)
    {
        wall4amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall5(double cleanAmount)
    {
        wall5amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall6(double cleanAmount)
    {
        wall6amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall3amount + wall4amount + wall5amount + wall6amount;
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
            checklist.checklist[2] = true;
            if (Wall3_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall3_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
