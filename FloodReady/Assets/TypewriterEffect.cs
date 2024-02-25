using UnityEngine;
using TMPro;
using System.Collections;

public class TypewriterEffect : MonoBehaviour
{
    public float delay = 0.1f; // Delay between each character
    private TMP_Text textMeshPro; // Reference to the TextMeshPro component
    private string fullText; // The full text to be displayed
    private string currentText = ""; // The current text being displayed

    // Start is called before the first frame update
    void Start()
    {
        // Get the TextMeshPro component attached to the same GameObject
        textMeshPro = GetComponent<TMP_Text>();
        // Get the full text from the TextMeshPro component
        fullText = textMeshPro.text;
        // Clear the text in the TextMeshPro component (to be displayed later with typewriter effect)
        textMeshPro.text = "";
        // Start the coroutine to display the text
        StartCoroutine(ShowText());
    }

    // Coroutine to gradually reveal the text character by character
    IEnumerator ShowText()
    {
        // Iterate over each character in the full text
        for (int i = 0; i <= fullText.Length; i++)
        {
            // Update the current text to include characters up to the current index
            currentText = fullText.Substring(0, i);
            // Update the TextMeshPro component with the current text
            textMeshPro.text = currentText;
            // Wait for a short delay before displaying the next character
            yield return new WaitForSeconds(delay);
        }
    }
}
