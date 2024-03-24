using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Room345 : MonoBehaviour
{
    private double wall3amount;
    private double wall4amount;
    private double wall5amount;
    public IconforLRW7 check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;
    public AudioSource Wall7_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public Material _material;


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

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = wall3amount + wall4amount + wall5amount;
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
            Wall3.GetComponent<Renderer>().material = _material;
            check.SetCheckIconVisible(true);
            check.SetUncheckIconVisible(false);
            checklist.checklist[1] = true;
            if (Wall7_Audio != null && !isPlay)
            {
                // Play the flush sound
                Wall7_Audio.Play();

                isPlay = true;
            }
            isSet = true;
        }
    }
}
