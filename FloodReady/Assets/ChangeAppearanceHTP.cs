using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ChangeAppearanceHTP : MonoBehaviour
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

            breakSound.Play(); // Play break sound when window appearance changes
        }
    }

    public void DestroyWindow()
    {
        Collider col = GetComponent<Collider>();
        if (col != null)
        {
            Destroy(col);
        }

        if (renderer != null)
        {
            renderer.enabled = false;
        }

        IsBroken = true;
    }
}
