using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room111213151617 : MonoBehaviour
{
    private double wall11amount;
    private double wall12amount;
    private double wall13amount;
    private double wall13_1amount;
    private double wall15amount;
    private double wall16amount;
    private double wall17amount;

    public IconforLRW2 check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;
    public AudioSource Wall2_Audio;
    private bool isPlay = false;


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

    public void wall13(double cleanAmount)
    {
        wall13amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall13_1(double cleanAmount)
    {
        wall13_1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    public void wall15(double cleanAmount)
    {
        wall15amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall16(double cleanAmount)
    {
        wall16amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall17(double cleanAmount)
    {
        wall17amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall11amount + wall12amount + wall13amount + wall13_1amount  + wall15amount + wall16amount + wall17amount;
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
            checklist.checklist[3] = true;
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
