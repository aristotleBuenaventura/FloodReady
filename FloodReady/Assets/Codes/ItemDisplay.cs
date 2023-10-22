using UnityEngine;
using TMPro; // For TextMeshPro

public class ItemDisplay : MonoBehaviour
{
    public TextMeshProUGUI textElement; // Reference to the TextMeshPro Text element
    public InventoryManager inventoryManager; // Reference to the InventoryManager script

    void Update()
    {
        if (textElement != null && inventoryManager != null)
        {
            string[] bagInventory = inventoryManager.bagInventory;

            // Create a string to display the array content
            string arrayContent = "";

            for (int i = 0; i < bagInventory.Length; i++)
            {
                arrayContent +=  bagInventory[i] + "\n";
            }


            // Update the TextMeshPro Text element with the array content
            textElement.text = arrayContent;

            Debug.Log(arrayContent);
        }
    }
}
