using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringHandCanvas : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public TotalPoints scoring; // Reference to the TaskPercentage script

    void Start()
    {
        // Assuming you have a reference to the GameObject with the TaskPercentage script attached
        // If not, you can find it using other methods like FindObjectOfType or GameObject.Find
        scoring = FindObjectOfType<TotalPoints>();
    }

    void Update()
    {
        // Check if taskPercentageScript is not null before updating the text
        if (scoring != null)
        {
            // Update the TextMeshPro text with taskPercentage value from TaskPercentage script
            textMeshPro.text = scoring.points + "";
        }
    }
}
