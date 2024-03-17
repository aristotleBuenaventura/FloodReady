using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayFloor : MonoBehaviour
{
    private double floor1amount;
    private double floor2amount;
    private double floor3amount;
    private double floor4amount;
    public IconforHF check;
    private bool isSet = false;
    public Hallway_Checklist checklist;
    public AudioSource Floor_Audio;
    private bool isPlay = false;

    public void floor1(double cleanAmount)
    {
        floor1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void floor2(double cleanAmount)
    {
        floor2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void floor3(double cleanAmount)
    {
        floor3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void floor4(double cleanAmount)
    {
        floor4amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = floor1amount + floor2amount + floor3amount + floor4amount;
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
            checklist.checklist[8] = true;
            if (Floor_Audio != null && !isPlay)
            {
                // Play the flush sound
                Floor_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
