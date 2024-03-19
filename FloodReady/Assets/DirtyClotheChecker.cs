using UnityEngine;
using System.Collections.Generic;

public class ClothesDetector : MonoBehaviour
{
    public string[] tagsToDetect; // Array of tags to detect

    private HashSet<string> detectedTags = new HashSet<string>(); // Set to store detected tags
    private Dictionary<string, GameObject> itemObjects = new Dictionary<string, GameObject>(); // Dictionary to map item names to GameObjects
    private bool allClothesDetected = false;
    private bool canvasShown = false; // Flag to track if canvas has been shown
    public RecoveryCanvasController goCheckOutSideCanvas;
    public CleaningChecklistCanvas cleaningCanvas;

    public GameObject redObject;
    public GameObject blueObject;
    public GameObject pinkObject;
    public GameObject whiteObject;
    public GameObject yellowObject;

    public iconforwhitedirty white;
    public iconforbluedirty blue;
    public iconforpinkdirty pink;
    public iconforyellowdirty yellow;
    public iconforreddirty red;
    public TaskPercentage score;
    public TotalPoints points;



    void Start()
    {
        // Populate the itemObjects dictionary with the GameObjects attached to this script
        itemObjects.Add("ClothesRed", redObject);
        itemObjects.Add("ClothesBlue", blueObject);
        itemObjects.Add("ClothesPink", pinkObject);
        itemObjects.Add("ClothesDirtyWhite", whiteObject);
        itemObjects.Add("ClothesYellow", yellowObject);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object's tag is in the list of tags to detect
        if (ArrayContains(tagsToDetect, other.tag) && !detectedTags.Contains(other.tag))
        {
            detectedTags.Add(other.tag); // Add the detected tag to the set
            string itemName = other.gameObject.name; // Get the name of the collided object
            AddItemToBag(itemName); // Pass the item name to AddItemToBag method
            CheckAllClothesDetected();
        }
    }

    // Helper method to check if an array contains a specific string
    bool ArrayContains(string[] array, string value)
    {
        foreach (string element in array)
        {
            if (element == value)
            {
                return true;
            }
        }
        return false;
    }

    void CheckAllClothesDetected()
    {
        if (detectedTags.Count == tagsToDetect.Length)
        {
            allClothesDetected = true; // Set allClothesDetected to true when all tags are detected
            if (!canvasShown)
            {
                canvasShown = true; // Set canvasShown to true to prevent showing the canvas multiple times
                Debug.Log("All clothes have been detected!");
                goCheckOutSideCanvas.goCheckOutSideCanvas();
                score.IncrementTaskPercentage(5);
                points.IncrementPoints(500);
                cleaningCanvas.deactivate();
                // You can perform any action you want here when all clothes are detected
            }
        }
        else
        {
            Debug.Log("Not all clothes have been detected yet.");
        }
    }

    private void AddItemToBag(string itemName)
    {
        if (itemObjects.ContainsKey(itemName))
        {
            GameObject itemObject = itemObjects[itemName];
            if (itemObject != null)
            {
             
                Debug.Log("Item " + itemName + " detected and activated.");

                // Call the functions to set icon visibility
                switch (itemName)
                {
                    case "ClothesRed":
                       
                        red.SetCheckIconVisible(true); // Assuming the check icon is associated with the 'red' object
                        break;
                    case "ClothesBlue":
                       
                        blue.SetCheckIconVisible(true); // Assuming the check icon is associated with the 'blue' object
                        break;
                    case "ClothesPink":
                     
                        pink.SetCheckIconVisible(true); // Assuming the check icon is associated with the 'pink' object
                        break;
                    case "ClothesDirtyWhite":
                     
                        white.SetCheckIconVisible(true); // Assuming the check icon is associated with the 'white' object
                        break;
                    case "ClothesYellow":
                      
                        yellow.SetCheckIconVisible(true); // Assuming the check icon is associated with the 'yellow' object
                        break;
                    default:
                        Debug.LogWarning("Invalid item name: " + itemName);
                        break;
                }
            }
            else
            {
                Debug.LogWarning("Item object for " + itemName + " is null.");
            }
        }
        else
        {
            Debug.LogWarning("Item " + itemName + " not found in itemObjects dictionary.");
        }
    }
}