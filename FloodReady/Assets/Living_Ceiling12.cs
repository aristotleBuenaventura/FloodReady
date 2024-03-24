using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Living_Ceiling12 : MonoBehaviour
{
    private double ceil1amount;
    private double ceil2amount;
    private double ceil3amount;
    public IconforLRC check;
    private bool isSet = false;
    public LivingRoom_Checklist checklist;
    public AudioSource Ceiling_Audio;
    private bool isPlay = false;
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public Material _material;

    public void ceil1(double cleanAmount)
    {
        ceil1amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void ceil2(double cleanAmount)
    {
        ceil2amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    public void ceil3(double cleanAmount)
    {
        ceil3amount = cleanAmount;
        CalculateTotalCleanAmount();
    }

    private void CalculateTotalCleanAmount()
    {
        double totalAmount = ceil1amount + ceil2amount + ceil3amount;
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
            checklist.checklist[5] = true;
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
