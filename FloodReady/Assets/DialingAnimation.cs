using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialingAnimation : MonoBehaviour
{
    public TextMeshProUGUI textElement;
    private string originalText = "Dialing";
    private string currentText;

    // Start is called before the first frame update
    void Start()
    {
        currentText = originalText;
        StartCoroutine(AnimateEllipses());
    }

    // Coroutine to animate ellipses
    IEnumerator AnimateEllipses()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f); // Adjust the time between each animation frame as needed
            currentText += ".";
            textElement.text = currentText;

            // Reset to the original text after three dots
            if (currentText.Length > originalText.Length + 3)
            {
                currentText = originalText;
            }
        }
    }
}
