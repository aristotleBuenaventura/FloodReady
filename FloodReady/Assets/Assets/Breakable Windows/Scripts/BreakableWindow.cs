using System.Collections;
using UnityEngine;

[AddComponentMenu("Breakable Windows/Breakable Window")]
[RequireComponent(typeof(AudioSource))]
public class BreakableWindow : MonoBehaviour
{
    public LayerMask layer;
    public Material[] windowMaterials;
    public AudioClip[] breakSounds; // Array of break sounds, one for each window material
    public breakIcon windowBreakIcon; // Reference to the BreakIcon script

    private Renderer renderer;
    private int currentMaterialIndex = 1; // Start counting from the second material
    private bool canBreak = true;
    private bool isLastWindow = false;
    public TaskPercentage breakwindowpercentage;
    public AudioSource breakSound; // Reference to the AudioSource for break sound
    public BreakAWindowScene2Icon task;
    public TotalPoints points;
    public GameObject hintWindow;

    public bool IsBroken { get; private set; } = false;

    private void Start()
    {
        ShowWindow();
        breakSound.Stop(); // Ensure break sound is initially stopped
    }

    private void ShowWindow()
    {
        renderer = GetComponent<Renderer>();
        if (renderer != null && windowMaterials != null && windowMaterials.Length > 0)
        {
            Material initialMaterial = new Material(windowMaterials[0]);
            renderer.material = initialMaterial;
        }
    }

    public void SetIsLastWindow(bool value)
    {
        isLastWindow = value;
    }

    public bool IsLastWindow()
    {
        return isLastWindow;
    }

    public void HandleCollision()
    {
        if (!IsBroken && canBreak)
        {
            StartCoroutine(HandleCollisionCoroutine());

            // Assuming windowBreakIcon is not null, set the check and uncheck icons accordingly

        }
    }

    private IEnumerator HandleCollisionCoroutine()
    {
        canBreak = false;


        ChangeWindowAppearance();

        // Add a cooldown period before the window can be broken again
        yield return new WaitForSeconds(1f);

        canBreak = true;

        if (currentMaterialIndex >= windowMaterials.Length - 1) // Check if the current material is the last one
        {
            Destroy(hintWindow);
            // Set it as the last window
            SetIsLastWindow(true);
            windowBreakIcon.SetCheckIconVisible(true);
            windowBreakIcon.SetUncheckIconVisible(false);
            task.SetCheckIconVisible(true);
            task.SetUncheckIconVisible(false);

        }
        else
        {
            currentMaterialIndex++;
        }
    }

    private void ChangeWindowAppearance()
    {
        Debug.Log("Changing window appearance");
        if (renderer != null && windowMaterials != null && windowMaterials.Length > 0)
        {
            Material newMaterial = new Material(windowMaterials[currentMaterialIndex]);
            renderer.material = newMaterial;

            // Play the corresponding break sound
            if (breakSounds != null && breakSounds.Length > currentMaterialIndex && breakSounds[currentMaterialIndex] != null)
            {
                GetComponent<AudioSource>().PlayOneShot(breakSounds[currentMaterialIndex]);
            }
        }
    }

    public void DestroyWindow()
    {
        Collider col = GetComponent<Collider>();
        if (col != null)
        {
            Destroy(col);
            breakSound.Play(); // Play break sound when window is destroyed
            breakwindowpercentage.IncrementTaskPercentage(20);
            points.IncrementPoints(2000);
        }

        if (renderer != null)
        {
            renderer.enabled = false;
        }

        IsBroken = true;
    }
}
