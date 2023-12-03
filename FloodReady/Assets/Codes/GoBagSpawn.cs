using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBagSpawn : MonoBehaviour
{
    public GameObject bagPrefab;  // Drag your bag asset prefab into this field in the Inspector


    void Start(){
        bagPrefab.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the trigger collider is with an object tagged as "Wall"
        if (other.CompareTag("Player"))
        {
            bagPrefab.SetActive(true);

        }
    }
}
