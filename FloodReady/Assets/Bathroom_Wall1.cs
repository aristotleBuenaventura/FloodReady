using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathroom_Wall1 : MonoBehaviour
{
    private double wall1amount;
    public IconforBRW1 check;
    private bool isSet = false;
    public Bathroom_Checklist checklist;
    public AudioSource Wall1_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public Material _material;

    public void wall1(double cleanAmount)
    {
        wall1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }


    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall1amount;
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
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[1] = true;
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
