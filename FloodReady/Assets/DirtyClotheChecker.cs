using UnityEngine;
using System.Collections.Generic;

public class ClothesDetector : MonoBehaviour
{
    public string[] tagsToDetect; // Array of tags to detect

    private HashSet<string> detectedTags = new HashSet<string>(); // Set to store detected tags
    private bool allClothesDetected = false;
    private bool canvasShown = false; // Flag to track if canvas has been shown
    public RecoveryCanvasController goCheckOutSideCanvas;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object's tag is in the list of tags to detect
        if (ArrayContains(tagsToDetect, other.tag) && !detectedTags.Contains(other.tag))
        {
            detectedTags.Add(other.tag); // Add the detected tag to the set
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
                // You can perform any action you want here when all clothes are detected
            }
        }
        else
        {
            Debug.Log("Not all clothes have been detected yet.");
        }
    }
}
