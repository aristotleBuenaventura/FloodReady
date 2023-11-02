using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip welcomeAudioClip; // Welcome audio clip
    public AudioClip backgroundMusicClip; // Reference to the background music AudioClip
    public AudioClip rainSoundClip; // Gentle rain sound effect

    public Canvas welcomeCanvas; // Reference to the Welcome canvas
    public TimerHandler timerHandler; // Reference to the TimerHandler script

    private AudioSource welcomeAudioSource; // AudioSource for welcome audio
    private AudioSource backgroundMusicSource; // AudioSource for background music
    private AudioSource rainSoundSource; // AudioSource for the rain sound effect

    public float audioDistance = 10.0f;

    void Start()
    {
        // Create new GameObjects to hold the AudioSources
        GameObject audioObject1 = new GameObject("WelcomeAudioObject");
        GameObject audioObject2 = new GameObject("BackgroundMusicObject");
        GameObject audioObject3 = new GameObject("RainSoundObject");

        // Add the AudioSource components to the new GameObjects
        welcomeAudioSource = audioObject1.AddComponent<AudioSource>();
        backgroundMusicSource = audioObject2.AddComponent<AudioSource>();
        rainSoundSource = audioObject3.AddComponent<AudioSource>();

        // Assign the audio clips to the corresponding audio sources
        welcomeAudioSource.clip = welcomeAudioClip;
        backgroundMusicSource.clip = backgroundMusicClip;
        rainSoundSource.clip = rainSoundClip;

        // Configure audio settings
        welcomeAudioSource.volume = 1.0f;
        backgroundMusicSource.loop = true;
        backgroundMusicSource.volume = 0.2f;
        rainSoundSource.loop = true;
        rainSoundSource.volume = 0.2f;

        // 3D audio settings for background music
        backgroundMusicSource.spatialBlend = 1.0f; // Full spatialization
        backgroundMusicSource.rolloffMode = AudioRolloffMode.Linear;
        backgroundMusicSource.maxDistance = audioDistance;

        // Play the welcome audio, rain sound, and show the "Welcome" canvas
        PlayWelcomeAudioAndShowCanvas();
    }

    void PlayWelcomeAudioAndShowCanvas()
    {
        welcomeAudioSource.Play();
        rainSoundSource.Play();
        welcomeCanvas.gameObject.SetActive(true);
        StartCoroutine(StartBackgroundMusicAndTimerDelayed());
    }

    IEnumerator StartBackgroundMusicAndTimerDelayed()
    {
        yield return new WaitForSeconds(welcomeAudioClip.length);

        // Start background music
        backgroundMusicSource.Play();

        // Start the timer
        timerHandler.StartTimer();
    }
}
