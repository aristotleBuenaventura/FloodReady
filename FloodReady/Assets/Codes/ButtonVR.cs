using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    public TextMeshProUGUI buttonText;
    public MeshRenderer videoCanvas;
    public VideoPlayer videoPlayer;
    AudioSource sound;
    bool isPlaying;
    bool canPressButton = true;
    public float delayDuration = 1f; // Adjust this value as needed
    public PlayVideoIcon videoIcon;
    public GameObject HintDestroy;

    void Start()
    {
        videoCanvas.gameObject.SetActive(false);
        sound = GetComponent<AudioSource>();
        isPlaying = false;
        buttonText.text = "START";

        // Subscribe to the loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Toggle video playback state when the button is pressed
        if (canPressButton)
        {
            ToggleVideoPlayback();
            StartCoroutine(DelayButtonPress());
        }
    }

    private IEnumerator DelayButtonPress()
    {
        canPressButton = false;
        yield return new WaitForSeconds(delayDuration);
        canPressButton = true;
    }

    private void ToggleVideoPlayback()
    {
        if (!isPlaying)
        {
            onPress.Invoke();
            sound.Play();
            StartCanvasVideo(); // Start the video
            isPlaying = true;
            buttonText.text = "STOP";
        }
        else
        {
            sound.Play();
            onRelease.Invoke();
            StopCanvasVideo(); // Stop the video
            isPlaying = false;
            buttonText.text = "START";
        }
    }

    public void StartCanvasVideo()
    {
        videoCanvas.gameObject.SetActive(true);
        videoPlayer.Play();
        Destroy(HintDestroy);
    }

    public void StopCanvasVideo()
    {
        videoPlayer.Stop();
        videoCanvas.gameObject.SetActive(false);
    }

    // Method to handle the video end event
    private void OnVideoEnd(VideoPlayer vp)
    {
        // Video has finished playing, reset button text to "START"

        videoIcon.SetUncheckIconVisible(false);
        videoIcon.SetCheckIconVisible(true);
        videoPlayer.Stop();
        videoCanvas.gameObject.SetActive(false);
        buttonText.text = "START";
    }

    // Unsubscribe from the loopPointReached event when the script is destroyed
    private void OnDestroy()
    {
        videoPlayer.loopPointReached -= OnVideoEnd;
    }
}
