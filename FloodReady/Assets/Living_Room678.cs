using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room678 : MonoBehaviour
{
    private double wall6amount;
    private double wall7amount;
    private double wall8amount;
    public IconforLRW6 check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;
    public AudioSource Wall6_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public Material _material;

    public void wall6(double cleanAmount)
    {
        wall6amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall7(double cleanAmount)
    {
        wall7amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall8(double cleanAmount)
    {
        wall8amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall6amount + wall7amount + wall8amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 10)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            Wall1.GetComponent<Renderer>().material = _material;
            Wall2.GetComponent<Renderer>().material = _material;
            Wall3.GetComponent<Renderer>().material = _material;
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[2] = true;
            if (Wall6_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall6_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
