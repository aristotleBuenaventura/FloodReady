using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // Import the Video namespace

public class TVController : MonoBehaviour
{
    private bool isTVOn;

    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component

    void Start()
    {
        // Get the VideoPlayer component attached to the TV GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        // Start with the TV turned off
        TurnOff();
    }

    public void TurnOn()
    {
        // Add code to turn on the TV (e.g., play a video, change materials, etc.)
        videoPlayer.Play(); // Play the video
        isTVOn = true;
        Debug.Log("TV is on!");
    }

    public void TurnOff()
    {
        // Add code to turn off the TV (e.g., stop video playback, reset materials, etc.)
        videoPlayer.Stop(); // Stop the video
        isTVOn = false;
        Debug.Log("TV is off!");
    }
}
