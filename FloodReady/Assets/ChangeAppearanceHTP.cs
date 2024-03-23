using System.Collections;
using UnityEngine;

[AddComponentMenu("Breakable Windows/Breakable Window")]
[RequireComponent(typeof(AudioSource))]
public class ChangeAppreanceHTP : MonoBehaviour
{
    public LayerMask layer;
    public Material[] windowMaterials;

    private Renderer renderer;
    private int currentMaterialIndex = 1; // Start counting from the second material
    private bool canBreak = true;
    private bool isLastWindow = false;
    public AudioSource breakSound; // Reference to the AudioSource for break sound

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
        
            // Set it as the last window
            SetIsLastWindow(true);
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
            breakSound.Play(); // Play break sound when window is destroyed
        }
    }

}
