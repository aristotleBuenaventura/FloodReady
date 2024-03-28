using UnityEngine;

public class Garbage : MonoBehaviour
{
    public GameObject trash; // Reference to the trash GameObject
    private float speed = 1.5f; // Speed at which the trash moves along the x-axis
    public float moveDuration = 20f; // Duration for which the trash should move

    private float elapsedTime = 0f; // Variable to track elapsed time
    private Vector3 originalPosition; // Variable to store the original position

    // Variables for wave motion along the y-axis
    private float waveFrequency = 5f; // Frequency of the wave
    private float waveAmplitude = 0.003f; // Amplitude of the wave

    void Start()
    {
        // Store the original position of the trash
        originalPosition = trash.transform.position;
    }

    void Update()
    {
        // Check if the trash has moved for the specified duration
        if (elapsedTime < moveDuration)
        {
            // Move the trash along the x-axis
            Vector3 movement = new Vector3(speed * Time.deltaTime, 0f, 0f);
            trash.transform.Translate(movement);

            // Calculate wave motion for y-axis
            float waveMovement = Mathf.Sin(Time.time * waveFrequency) * waveAmplitude;
            trash.transform.position += new Vector3(0f, waveMovement, 0f);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;
        }
        else
        {
            // Reset elapsed time
            elapsedTime = 0f;
            // Move the trash back to its original position
            trash.transform.position = originalPosition;
        }
    }
}
