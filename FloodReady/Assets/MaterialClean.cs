using TMPro;
using UnityEngine;

public class MaterialClean : MonoBehaviour
{

    
    // Reference to the TextMeshPro component
    private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        // Get the TextMeshPro component attached to this GameObject
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshPro component not found!");
        }
    }

    private void Update()
    {
        // Access cleanAmount from the Clean script
        string MaterialText = MaterialManager.MaterialValue;

        // Display cleanAmount in the TextMeshPro component
        textMeshPro.text = "Clean Percentage:" + MaterialText;
    }
}
