using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room12 : MonoBehaviour
{
    private double wall1amount;
    private double wall2amount;
    public IconforLRW1 check;
    private bool isSet = false; // Moved isSet variable declaration outside of the method
    public LivingRoom_Checklist checklist;
    public AudioSource Wall1_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public Material _material;


    public void wall1(double cleanAmount)
    {
        wall1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void wall2(double cleanAmount)
    {
        wall2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall1amount + wall2amount;
        clean_as_a_whole(totalAmount);
    }

    public void clean_as_a_whole(double totalAmount)
    {
        int totalAmountInt = (int)totalAmount;

        if (totalAmountInt >= 80)
        {
            totalAmountInt = 100; // Update totalAmountInt directly to 100
        }

        CleanAmountManager.UpdateCleanAmount(totalAmountInt); // Update CleanAmountManager after modifying totalAmountInt

        if (totalAmountInt == 100 && !isSet)
        {
            Wall1.GetComponent<Renderer>().material = _material;
            Wall2.GetComponent<Renderer>().material = _material;
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[0] = true;
            // Check if flushSound is assigned
            if (Wall1_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall1_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }


}
