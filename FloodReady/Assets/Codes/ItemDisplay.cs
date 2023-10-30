using UnityEngine;
using TMPro; // For TextMeshPro
using System.Collections.Generic; // Add this line

public class ItemDisplay : MonoBehaviour
{
    public TextMeshProUGUI textElement; // Reference to the TextMeshPro Text element
    public InventoryManager inventoryManager; // Reference to the InventoryManager script

    void Update()
    {
        if (textElement != null && inventoryManager != null)
        {
            List<string> bagInventory = inventoryManager.bagInventory; // Change the type to List<string>

            // Create a string to display the list content
            string listContent = "";

            foreach (string item in bagInventory)
            {
                listContent += item + "\n";
            }

            // Update the TextMeshPro Text element with the list content
            textElement.text = listContent;
        }
    }
}
