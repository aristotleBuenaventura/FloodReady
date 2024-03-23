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

    void Start()
    {
        videoCanvas.gameObject.SetActive(false);
        sound = GetComponent<AudioSource>();
        isPlaying = false;
        buttonText.text = "START";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPlaying)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            onPress.Invoke();
            sound.Play();
            StartCanvasVideo(); // Start the video when the button is pressed
            isPlaying = true;
            buttonText.text = "STOP";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isPlaying)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            StopCanvasVideo(); // Stop the video when the button is released
            isPlaying = false;
            buttonText.text = "START";
        }
    }

    public void StartCanvasVideo()
    {
        videoCanvas.gameObject.SetActive(true);
        videoPlayer.Play();
        StartCoroutine(WaitForVideoToEnd());
    }

    public void StopCanvasVideo()
    {
        videoPlayer.Stop();
        videoCanvas.gameObject.SetActive(false);
    }

    IEnumerator WaitForVideoToEnd()
    {
        while (videoPlayer.isPlaying)
        {
            yield return null;
        }
        // Video has finished playing, change button text back to "START"
        buttonText.text = "START";
    }
}
