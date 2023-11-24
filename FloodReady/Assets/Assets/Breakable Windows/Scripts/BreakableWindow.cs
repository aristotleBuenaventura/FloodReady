using System.Collections;
using UnityEngine;

[AddComponentMenu("Breakable Windows/Breakable Window")]
[RequireComponent(typeof(AudioSource))]
public class BreakableWindow : MonoBehaviour
{
    public LayerMask layer;
    public AudioClip breakingSound;
    public Material[] windowMaterials;

    private Renderer renderer;
    private int currentMaterialIndex = 1; // Start counting from the second material
    private bool canBreak = true;

    public bool IsBroken { get; private set; } = false;

    private void Start()
    {
        ShowWindow();
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

        if (breakingSound != null)
        {
            GetComponent<AudioSource>().clip = breakingSound;
            GetComponent<AudioSource>().Play();
        }

        ChangeWindowAppearance();

        // Add a cooldown period before the window can be broken again
        yield return new WaitForSeconds(1f);

        canBreak = true;

        if (++currentMaterialIndex >= windowMaterials.Length)
        {
            DestroyWindow();
        }
    }

    private void ChangeWindowAppearance()
    {
        Debug.Log("Changing window appearance");
        if (renderer != null && windowMaterials != null && windowMaterials.Length > 0)
        {
            Material newMaterial = new Material(windowMaterials[currentMaterialIndex]);
            renderer.material = newMaterial;
        }
    }

    private void DestroyWindow()
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
