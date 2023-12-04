using System.Collections;
using UnityEngine;

public class GoBagSpawn : MonoBehaviour
{
    public GameObject bagPrefab;  // Drag your bag asset prefab into this field in the Inspector
    public EscapeCanvasController dial161Canvas;

    void Start()
    {
        bagPrefab.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collider is with an object tagged as "Player"
        if (other.CompareTag("Player"))
        {
            bagPrefab.SetActive(true);
            dial161Canvas.ShowSearchGoBagCanvas(true);
        }
    }

}
