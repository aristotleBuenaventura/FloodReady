using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalPoints : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public int points = 0;

    void Update()
    {
        // Update the TextMeshPro text with taskPercentage value
        textMeshPro.text = points + " pts";
    }

    // Function to increment taskPercentage by a specified value
    public void IncrementPoints(int incrementValue)
    {
        points += incrementValue;
    }

    public void DecrementPoints(int decrementValue)
    {
        points -= decrementValue;
    }
}
