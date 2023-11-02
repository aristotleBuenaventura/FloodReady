using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[AddComponentMenu("Breakable Windows/Breakable Window")]
[RequireComponent(typeof(AudioSource))]
public class BreakableWindow : MonoBehaviour
{
    [Tooltip("Layer should be TransparentFX or your own layer for breakable windows.")]
    public LayerMask layer;

    public bool useCollision = false;
    public AudioClip breakingSound;

    [HideInInspector]
    public bool isBroken = false;

    void OnCollisionEnter(Collision col)
    {
        if (useCollision && !isBroken)
        {
            string collidedObjectName = col.gameObject.name;
            string collidedObjectTag = col.gameObject.tag;

            UnityEngine.Debug.Log("Collided object name: " + collidedObjectName);
            UnityEngine.Debug.Log("Collided object tag: " + collidedObjectTag);

            // Check if the collided object has the name "PryBar" and tag "PryBar"
            if (collidedObjectName == "PryBar" && collidedObjectTag == "PryBar")
            {
                UnityEngine.Debug.Log("PryBar collided with the window.");
                breakWindow();
            }
        }
    }






    public void breakWindow()
    {
        if (!isBroken)
        {
            // Play the breaking sound
            if (breakingSound != null)
            {
                GetComponent<AudioSource>().clip = breakingSound;
                GetComponent<AudioSource>().Play();
            }

            // Remove the collider to make it breakable
            Collider col = GetComponent<Collider>();
            if (col != null)
            {
                Destroy(col);
            }

            // Destroy the renderer to make it invisible
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                Destroy(renderer);
            }

            // Set the isBroken flag to true
            isBroken = true;
        }
    }
}
