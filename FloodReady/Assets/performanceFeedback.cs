using UnityEngine;
using TMPro;

public class PerformanceFeedback : MonoBehaviour
{
    public TotalPoints totalPointsScript;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI feedbackText2;

    void Start()
    {
        UpdatePerformanceFeedback();
    }

    void Update()
    {
        // Check for changes in total points and update feedback accordingly
        UpdatePerformanceFeedback();
    }

    void UpdatePerformanceFeedback()
    {
        int points = totalPointsScript.points;

        if (points >= 13000)
        {
            feedbackText.text = "YOU ARE NOW FLOODREADY";
            feedbackText2.text = "Your performance showcases mastery in flood preparedness training";
        }
        else if (points >= 10000 && points <= 12000)
        {
            feedbackText.text = "YOU ARE ON THE RIGHT PATH";
            feedbackText2.text = "Your performance indicates progress, but additional effort is required";
        }
        else if (points >= 8000 && points <= 9000)
        {
            feedbackText.text = "YOU ARE DOING WELL";
            feedbackText2.text = "Your performance demonstrates noticeable progress in flood response";
        }
        else if (points >= 6000 && points <= 8000)
        {
            feedbackText.text = "GOOD BUT NEED MORE PRACTICE";
            feedbackText2.text = "Your performance is acceptable, but lacks depth in flood preparedness";
        }
        else if (points >= 3000 && points <= 5000)
        {
            feedbackText.text = "YOU NEED PRACTICE";
            feedbackText2.text = "Immediate improvement is required.";
        }
        else if (points >= 0 && points <= 2000)
        {
            feedbackText.text = "YOU ARE NOT FLOODREADY";
            feedbackText2.text = "You failed your training. You need to be floodready!";
        }
    }
}
